# Documentación del proyecto

Esta carpeta contiene el informe de la actividad y todos los archivos necesarios para reproducirlo.

## Contenido

| Archivo / carpeta | Descripción |
|---|---|
| `informe.tex` | Documento fuente en LaTeX (archivo principal). |
| `informe.pdf` | Informe compilado listo para lectura. |
| `referencias.bib` | Bibliografía en formato BibLaTeX. |
| `Figuras/` | Todas las figuras y capturas incluidas en el informe. |
| `informe.*` (aux, bbl, log, toc, etc.) | Archivos auxiliares generados por la compilación. |

## Compilación

```bash
pdflatex informe.tex
biber informe
pdflatex informe.tex
pdflatex informe.tex
```

Requiere una distribución LaTeX (MiKTeX o TeX Live) con `biblatex` y `biber`.
