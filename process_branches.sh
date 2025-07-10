#!/bin/bash

# --- CONFIGURACIÓN ---
# Define la rama principal de tu proyecto
MAIN_BRANCH="main" # O "master" si es tu caso

# Directorio base del proyecto
PROJECT_DIR="$(pwd)"

# Define los grupos de archivos para cada rama
declare -A FILES_FOR_BRANCH

# Archivos base que estarán en todas las ramas si se necesitan, pero principalmente en main.
# Para este script, asumiremos que MAIN_BRANCH tendrá todos, y las otras solo los suyos.
# Estos archivos serán temporalmente ignorados/eliminados en las ramas de feature para el commit inicial.
# Pero ten en cuenta que un flujo de trabajo típico de Git los mantendría en todas las ramas.

# --- GRUPO LOGIN ---
FILES_FOR_BRANCH["feature/Login"]="\
Form1.cs \
Form1.Designer.cs \
Form1.resx \
frmCodigo_Acceso.cs \
frmCodigo_Acceso.Designer.cs \
frmCodigo_Acceso.resx \
frmNueva_Contrasena.cs \
frmNueva_Contrasena.Designer.cs \
frmNueva_Contrasena.resx \
clsrecuperacion.cs \
frmRecuperacion_De_Contrasenas.cs \
frmRecuperacion_De_Contrasenas.Designer.cs \
frmRecuperacion_De_Contrasenas.resx"

# --- GRUPO ADMINISTRADOR ---
FILES_FOR_BRANCH["feature/Administrador"]="\
frm_agregar_admin.cs \
frm_agregar_admin.Designer.cs \
frm_agregar_admin.resx \
frm_modificacion_datos.cs \
frm_modificacion_datos.Designer.cs \
frm_modificacion_datos.resx \
frm_modificar_admin.cs \
frm_modificar_admin.Designer.cs \
frm_modificar_admin.resx \
frmAdministrador.cs \
frmAdministrador.Designer.cs \
frmAdministrador.resx \
frmCierre.cs \
frmCierre.Designer.cs \
frmCierre.resx \
frmMigracion.cs \
frmMigracion.Designer.cs \
frmMigracion.resx \
frmModificacionDoc.cs \
frmModificacionDoc.Designer.cs \
frmNuevoPeriodo.Designer.cs\
frmModificacionDoc.resx \
frmNuevoPeriodo.cs\
frmNuevoPeriodo.resx\
frm_Admin_Periodo.Designer.cs\
frm_Admin_Periodo.cs\
frm_Admin_Periodo.resx" 
# --- GRUPO DECANO ---
FILES_FOR_BRANCH["feature/Decano"]="\
frmDecano.cs \
frmDecano.Designer.cs \
frmDecano.resx \
obs_justificacion.cs \
obs_justificacion.Designer.cs \
obs_justificacion.resx\
frm_observacion_decano.cs"

# --- GRUPO SUPERVISOR ---
FILES_FOR_BRANCH["feature/Supervisor"]="\
frmDocente.cs \
frmDocente.Designer.cs \
frmDocente.resx \
frmObservacion.cs \
frmObservacion.Designer.cs \
frmObservacion.resx \
frmSupervisor.cs \
frmSupervisor.Designer.cs \
frmSupervisor.resx"

# --- ARCHIVOS BASE / COMPARTIDOS ---
# Estos archivos se mantendrán en la rama principal.
# Si quieres que se excluyan del historial inicial de las ramas de feature,
# el script los eliminará temporalmente en esas ramas antes del commit inicial.
SHARED_FILES="\
App.config \
conexionbd.cs \
.gitattributes \
.gitignore \
packages.config \
Program.cs \
Proyecto_DesarrolloSoftware.csproj"

# Directorios a ignorar/restaurar
IGNORED_DIRS=".git .vs bin obj packages Properties Resources"

# --- FUNCIONES DE AYUDA ---

# Función para obtener todos los archivos rastreados por Git (excluyendo directorios de Git)
get_all_tracked_files() {
    git ls-files | grep -v -E "(^.git/|^.vs/|^bin/|^obj/|^packages/|^Properties/|^Resources/)"
}

# --- SCRIPT PRINCIPAL ---

echo "Iniciando proceso de separación de archivos en ramas..."
echo "----------------------------------------------------"

# 1. Asegurarse de que el repositorio está limpio
echo "1. Verificando el estado del repositorio..."
if ! git diff-index --quiet HEAD --; then
    echo "¡ERROR! Tienes cambios pendientes o no commitidos."
    echo "Por favor, haz commit o descarta tus cambios antes de ejecutar este script."
    exit 1
fi

CURRENT_BRANCH=$(git rev-parse --abbrev-ref HEAD)
if [ "$CURRENT_BRANCH" != "$MAIN_BRANCH" ]; then
    echo "Cambiando a la rama $MAIN_BRANCH..."
    git checkout "$MAIN_BRANCH" || { echo "Error al cambiar a $MAIN_BRANCH. Saliendo."; exit 1; }
fi

# Guardar un estado limpio de la rama principal
INITIAL_COMMIT=$(git rev-parse HEAD)
echo "Commit inicial de la rama $MAIN_BRANCH: $INITIAL_COMMIT"

# Obtener una lista completa de todos los archivos del proyecto (excluyendo los directorios de Git)
ALL_PROJECT_FILES=$(get_all_tracked_files)

# --- CREAR Y POBLAR CADA RAMA DE CARACTERÍSTICA ---
for BRANCH_NAME in "${!FILES_FOR_BRANCH[@]}"; do
    echo "----------------------------------------------------"
    echo "Procesando rama: $BRANCH_NAME"

    # Crear la nueva rama y cambiar a ella
    git checkout -b "$BRANCH_NAME" || { echo "Error al crear/cambiar a la rama $BRANCH_NAME. Saliendo."; exit 1; }

    # Lista de archivos que PERTENECEN a esta rama
    FILES_TO_KEEP="${FILES_FOR_BRANCH[$BRANCH_NAME]}"

    # Archivos a eliminar/excluir temporalmente para este commit
    FILES_TO_REMOVE=""
    for file in $ALL_PROJECT_FILES; do
        found=false
        for keep_file in $FILES_TO_KEEP; do
            if [[ "$file" == "$keep_file" ]]; then
                found=true
                break
            fi
        done
        # También excluir archivos compartidos del commit inicial de la rama de característica
        for shared_file in $SHARED_FILES; do
            if [[ "$file" == "$shared_file" ]]; then
                found=true # Marcar como encontrado para no añadir a FILES_TO_REMOVE
                break
            fi
        done
        if [ "$found" == false ]; then
            FILES_TO_REMOVE+=" $file"
        fi
    done

    # Mover archivos al directorio de trabajo temporal si existen
    TEMP_DIR=".temp_files_to_restore"
    mkdir -p "$TEMP_DIR"

    echo "Archivos a eliminar temporalmente para este commit en $BRANCH_NAME:"
    for file_to_rm in $FILES_TO_REMOVE; do
        if [ -f "$file_to_rm" ]; then
            mv "$file_to_rm" "$TEMP_DIR/" || echo "Advertencia: No se pudo mover $file_to_rm"
        elif [ -d "$file_to_rm" ]; then
            # Si es un directorio, intentar moverlo recursivamente
            mv "$file_to_rm" "$TEMP_DIR/" || echo "Advertencia: No se pudo mover directorio $file_to_rm"
        fi
        echo "- $file_to_rm"
    done

    # Quitar los archivos eliminados del staging area si estaban allí
    git rm -r --cached . > /dev/null 2>&1 # Limpiar índice
    git add . # Volver a añadir lo que queda

    # Hacer el commit inicial para esta rama
    git commit -m "feat($BRANCH_NAME): Initial files for $BRANCH_NAME module" || echo "No hay cambios para commitear en $BRANCH_NAME, o el commit inicial ya existe."

    # Restaurar los archivos temporalmente movidos
    echo "Restaurando archivos eliminados temporalmente..."
    mv "$TEMP_DIR"/* . > /dev/null 2>&1
    rmdir "$TEMP_DIR" > /dev/null 2>&1 || rm -rf "$TEMP_DIR" # Limpiar directorio temporal

    # Descartar cualquier cambio de archivos restaurados para que el directorio de trabajo esté limpio
    git reset --hard HEAD > /dev/null 2>&1
    echo "Rama $BRANCH_NAME configurada con sus archivos."
done

echo "----------------------------------------------------"
echo "Volviendo a la rama $MAIN_BRANCH y asegurando todos los archivos..."
git checkout "$MAIN_BRANCH" || { echo "Error al volver a $MAIN_BRANCH. Saliendo."; exit 1; }

# Asegurarse de que todos los archivos estén presentes en la rama principal
# Esto se logra volviendo al commit inicial donde todos estaban presentes.
git reset --hard "$INITIAL_COMMIT" || { echo "Error al restaurar el commit inicial de $MAIN_BRANCH. Saliendo."; exit 1; }

echo "----------------------------------------------------"
echo "Proceso completado. Tus ramas han sido creadas con sus commits iniciales."
echo "La rama '$MAIN_BRANCH' debería contener ahora todos los archivos."
echo "Puedes verificar con 'git branch' y 'git log' en cada rama."
echo "¡Recuerda que este es un flujo de trabajo inusual! El desarrollo continuará con todos los archivos presentes en cada rama."
