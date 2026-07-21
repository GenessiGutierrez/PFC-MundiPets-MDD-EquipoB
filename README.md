# PFC-MundiPets-MDD-EquipoB

Repositorio de la actividad **Exposición-Demostración: MDD (UML → Código)** de la asignatura **Ingeniería de Requerimientos**, aplicada sobre el Proyecto Fin de Curso **MundiPets**.

El trabajo demuestra el ciclo completo de *Model-Driven Development* (MDD) sobre el módulo de **Gestión de Solicitud de Adopción**: desde el modelo UML de origen construido en StarUML hasta la generación automática de código C#, su verificación y el cierre del ciclo mediante *round-trip engineering*.

## Equipo B

| Integrante | Rol |
|---|---|
| Gutierrez Ortega Genesis Adriana | Titular / Líder / Modeladora UML |
| Cordova Carreño Mayra Lucila | Investigadora |
| Naranjo Flores Anderson Jeampiere | Verificador |

**Materia:** Ingeniería de Requerimientos · **Curso:** Cuarto Semestre «B»
**Docente:** Ing. Guerrero Ulloa Gleiston Cicerón, PhD.
**Sistema PFC:** MundiPets · UTEQ · 2026–2027 PPA

## Estructura del repositorio

| Carpeta | Contenido |
|---|---|
| `Docs/` | Informe en LaTeX (`informe.tex`), PDF compilado, bibliografía y figuras. |
| `Modelo/` | Modelos nativos de StarUML (`.mdj`): diagrama de clases y de casos de uso. |
| `Perfiles/` | Documentación del perfil UML y estereotipos aplicados al modelo. |
| `Plantillas/` | Extensión de generación de código C# de StarUML utilizada. |
| `Generado/` | Código fuente C# generado automáticamente a partir del modelo. |
| `Evidencias/` | Capturas del proceso y video de la demostración en vivo. |
| `Exposicion/` | Diapositivas de la exposición en formato PDF. |
| `Partes_Individuales/` | Aportes individuales de cada integrante del equipo. |

## Herramienta y tecnología

- **Herramienta CASE:** StarUML 7.1.0 (MKLabs)
- **Extensión de generación:** C# Code Generation and Reverse Engineering
- **Lenguaje objetivo:** C#

## Reproducibilidad del informe

El PDF del informe se genera a partir de `Docs/informe.tex`. Para compilarlo:

```bash
cd Docs
pdflatex informe.tex
biber informe
pdflatex informe.tex
pdflatex informe.tex
```

Requiere una distribución LaTeX (MiKTeX o TeX Live) con el paquete `biblatex` y `biber`.
