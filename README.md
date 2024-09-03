
# Proyecto: Ejemplo de Programación en C#

Este proyecto es un ejemplo de programación en C# que incluye varias clases para manipular objetos, trabajar con cadenas de texto y realizar operaciones en arreglos. 

## Estructura del Proyecto

El proyecto contiene las siguientes clases:

- **Program**: Contiene el método principal (`Main`) que instancia objetos de otras clases y utiliza sus funcionalidades.
- **Person**: Representa una entidad persona con propiedades como `Name`, `LastName`, `Address`, `Email` y `Phone`. Incluye un método `ToString` para mostrar los detalles de la persona.
- **StringUtilities**: Proporciona una funcionalidad para contar las vocales en una cadena de texto.
- **ArrayUtilities**: Ofrece métodos para obtener el valor mínimo y máximo de un arreglo de enteros.

## Clases y Métodos

### Program
El punto de entrada del programa, que ejecuta el método `Main`. En este método se crean instancias de la clase `Person` y se utilizan utilidades de arreglos para mostrar el valor mínimo y máximo de un arreglo.

#### Métodos

- **`Main(string[] args)`**: Método principal del programa que inicializa una instancia de `Person` y utiliza métodos de `ArrayUtilities`.
- **`PrintMessage(string message)`**: Método auxiliar para imprimir mensajes en la consola.

### Person
Esta clase modela una persona con varias propiedades y proporciona una representación en cadena.

#### Propiedades

- `Name`: Nombre de la persona.
- `LastName`: Apellido de la persona.
- `Address`: Dirección de la persona.
- `Email`: Correo electrónico de la persona.
- `Phone`: Teléfono de la persona.

#### Métodos

- **`ToString()`**: Retorna una representación en cadena de la persona con sus propiedades.

### StringUtilities
Proporciona utilidades para trabajar con cadenas de texto.

#### Métodos

- **`CountVowels(string input)`**: Cuenta el número de vocales en una cadena dada. Utiliza un enum para definir las vocales y valida si cada carácter es una vocal.

### ArrayUtilities
Proporciona utilidades para trabajar con arreglos de enteros.

#### Métodos

- **`GetMax(int[] intsArray)`**: Retorna el valor máximo del arreglo.
- **`GetMin(int[] intsArray)`**: Retorna el valor mínimo del arreglo.
- **`validateArray(int[] intsArray)`**: Método auxiliar que valida si un arreglo es nulo o está vacío y lanza una excepción si es el caso.

### Ejecución del Programa

Para ejecutar este programa:

1. Clona el repositorio o descarga los archivos de código.
2. Asegúrate de tener un entorno de desarrollo de C# configurado, como Visual Studio o Visual Studio Code con .NET SDK instalado.
3. Compila y ejecuta el programa utilizando el comando:

    ```bash
    dotnet run
    ```

## Notas

- Asegúrate de manejar correctamente las excepciones cuando trabajes con los métodos de `ArrayUtilities`, especialmente si los arreglos pueden ser nulos o vacíos.
- La implementación actual del conteo de vocales en `StringUtilities` podría mejorarse utilizando expresiones regulares para mayor flexibilidad.

