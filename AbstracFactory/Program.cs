using AbstracMethod.Factory;

DispositivoFactory Producto;

// Laptop
Producto = new LaptopFactory();
Producto.seleccionar();
Console.WriteLine("Se define el tipo como " + Producto.GetType());

// Tablet
Producto = new TabletFactory();
Producto.seleccionar();
Console.WriteLine("Se define el tipo como " + Producto.GetType());

// Smartphone
Producto = new SmartphoneFactory();
Producto.seleccionar();
Console.WriteLine("Se define el tipo como " + Producto.GetType());