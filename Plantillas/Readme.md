# Plantillas / Extensión de generación de código

Contiene la extensión de StarUML utilizada para la generación automática de código a partir del modelo UML.

## Extensión utilizada

**C# Code Generation and Reverse Engineering** (`staruml.csharp`), invocada desde StarUML mediante `Tools → C# → Generate Code`.

## Características

- La transformación modelo-a-texto está **codificada de forma fija** dentro del complemento (módulo `code-generator.js`); se clasifica como plantilla estándar **no editable** desde la interfaz.
- No utiliza motores de plantillas editables (EJS, Velocity).
- El comportamiento de mapeo de tipos y asociaciones puede consultarse en el código fuente incluido (`code-generator.js`, `code-analyzer.js`, `codegen-utils.js`).

## Archivos principales

| Archivo | Descripción |
|---|---|
| `staruml.csharp/code-generator.js` | Lógica de generación de código C# (función `getType()`, `writeClass()`, etc.). |
| `staruml.csharp/code-analyzer.js` | Análisis del modelo para ingeniería inversa. |
| `staruml.csharp/main.js` | Punto de entrada de la extensión. |
| `staruml.csharp/menus/menu.json` | Definición de las entradas de menú en StarUML. |
| `staruml.csharp/package.json` | Metadatos de la extensión. |

Esta extensión se incluye en el repositorio como evidencia de la configuración de generación utilizada, tal como exige la guía de la actividad.
