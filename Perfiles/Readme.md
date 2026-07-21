# Perfil UML utilizado

Se utilizó la extensión "UML Standard Profile (v2)" de StarUML, que provee los estereotipos estándar de UML 2.x. De este perfil se aplicó el estereotipo `<<Entity>>` a todas las clases del diagrama, indicando que representan entidades persistentes del dominio.

El perfil es una extensión instalada en StarUML (no un archivo generado por el proyecto), por lo que no se incluye como archivo separado; el estereotipo aplicado queda almacenado dentro del modelo nativo (`Modelo/DiagramadeClases-GestionSolicitudAdopcion.mdj`).

## Nota sobre la generación de código

El estereotipo `<<Entity>>` cumple una función exclusivamente **documental** dentro del modelo UML: la extensión de generación de C# no lo traduce a ninguna anotación, atributo o comentario en el código resultante. Su propósito es clasificar semánticamente las clases como entidades del dominio.
