string ubicacionDelArchivo = "C:\\Users\\JesusIsraelGutierrez\\Desktop\\Apuntes\\Python\\Productos.csv";
using (System.IO.StreamReader archivo = new System.IO.StreamReader(ubicacionDelArchivo))
{
    string separador = ",";
    string linea;
    while ((linea = archivo.ReadLine()) != null)
    {
        string[] fila = linea.Split(separador);
        string Descripcion = fila[0];
        string Precio = fila[1];
        string Existencia = fila[2];

        // Cambia la forma de mostrar los valores
        Console.WriteLine($"{Descripcion}, {Precio}, {Existencia}");
    }
}
