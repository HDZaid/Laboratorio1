// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Menu Principal");
string productoUno = "";
string productoDos = "";
string productoTres = "";

double Producto1 = 10;
double producto2 = 15;
double producto3 = 20;
double total = 0;
bool opcionWhile = true;
bool opcionWhile2 = false;


while (opcionWhile)
{
    Console.WriteLine("ingresa una opcion");
    Console.WriteLine("0 NOMBRAR PRODUCTOS");
    Console.WriteLine("1 MOSTRAR PRODUCTOS");
    Console.WriteLine("2 Comprar PRODUCTOS");
    Console.WriteLine("3 Salir");
    int opcionesMenu = Convert.ToInt32(Console.ReadLine());
    switch (opcionesMenu)
    {
        case 0:
            Console.WriteLine("CREAR PRODUCTOS");
            Console.WriteLine("SON 3 PRODUCTOS");
            agregarProductos();
            break;
        case 1:
            Console.WriteLine("Mostrar Producto");
            MostrarProductos();
            break;
            
        case 2:
            try
            {
                Console.WriteLine("CALCULAR TOTAL COMPRA");
                MostrarProductos();
                AgegarAlCarrito();
            }catch(Exception ex)
            {
                Console.WriteLine("ERROR");
            }
            break; 
        
        case 3:
            Console.WriteLine("SALIR");
            opcionWhile = false; 
            break;
    }
}


void agregarProductos()
{
    productoUno = Console.ReadLine();
    productoDos = Console.ReadLine();
    productoTres = Console.ReadLine();
}
void MostrarProductos()
{
    Console.WriteLine($"Productos Disponibles:{productoUno}, {productoDos} y {productoTres}");
}
void AgegarAlCarrito()
{
    
        Console.WriteLine("Que productos quiere comprar? [salir] para dejar de comprar");
        string productoCompra = Console.ReadLine();

        while (true)
        {
        if (productoCompra == productoUno)
        {
            total += 10;
        }
        else if (productoCompra == productoDos)
        {
            total += 15;
        }
        else if (productoCompra == productoTres)
        {
            total += 20;
        }
        
        
        } 
    
}
        
