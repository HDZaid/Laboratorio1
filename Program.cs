// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Menu Principal");
string productoUno = "ketchup" + " Q.10.00";
string productoDos = "Jamon Q.15.00";
string productoTres = "Queso Q.20.00";

double Producto1 = 10;
double producto2 = 15;
double producto3 = 20;


while (true)
{
    Console.WriteLine("ingresa una opcion");
    int opcionesMenu = Convert.ToInt32(Console.ReadLine());
    switch (opcionesMenu)
    {
        case 1:
            Console.WriteLine("Mostrar Producto");
            MostrarProductos();
            break;
            
        case 2:
            Console.WriteLine("CALCULAR TOTAL COMPRA");
            break; 
        
        case 3:

            break;
    }
}


void MostrarProductos()
{
    Console.WriteLine($"Productos Disponibles:{productoUno}, {productoDos} y {productoTres}");
}
void AgegarAlCarrito()
{
    Console.WriteLine("Que productos quiere comprar?");

}