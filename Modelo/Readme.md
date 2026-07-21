# Modelo UML de origen

Contiene los modelos nativos de **StarUML** (`.mdj`) que sirven como origen para la generación de código.

## Archivos

| Archivo | Descripción |
|---|---|
| `DiagramadeClases-GestionSolicitudAdopcion.mdj` | Diagrama de clases del módulo de Gestión de Solicitud de Adopción (8 clases del dominio). Es el modelo base para la generación de código C#. |
| `DiagramaCasodeUso-GestionSolicitudAdopcion.mdj` | Diagrama de casos de uso del módulo, elaborado a partir del requisito funcional RF-05. |

## Notas

- Las 8 clases del dominio están estereotipadas como `<<Entity>>` mediante el UML Standard Profile de StarUML (ver carpeta `Perfiles/`).
- El diagrama de clases fue validado en StarUML sin errores antes de la generación.
- Para abrir estos archivos se requiere StarUML 7.x o superior.
