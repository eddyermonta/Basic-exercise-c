/*
encontrar cantidad de vocales en un string
maximo y minimo de un array de enteros
*/


class Program {

    public static void Main(string[] args){
        Person person = new Person();
        person.Name = "John Doe";
        person.LastName = "sdfsf";
        person.Address = "123 Main St";
        person.Phone = "";

        /*PrintMessage(person.ToString());
        //int vowelscounted = StringUtilities.CountVowels(person.Name);
        //PrintMessage($"Number of vowels in Name: {vowelscounted}");
        */
        int[] array = {5,5,4,1,2,3,5,7,8};
        int min = ArrayUtilities.GetMin(array);
        int max = ArrayUtilities.GetMax(array);
        PrintMessage($"Minimum: {min}, Maximum: {max}");
    }

    public static void PrintMessage(string message){
        Console.WriteLine(message);
    }
}
