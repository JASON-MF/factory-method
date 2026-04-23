using AFRetroAlimentacion.FactoryClass;
using AFRetroAlimentacion.Reglas;
using AFRetroAlimentacion.SeleccionDeAnimal;

SeleccionAnimal seleccionar;
seleccionar = new MariposaFactory();
IAcciones habilidad = seleccionar.Seleccionar();
seleccionar.Actividad();

seleccionar = new CangrejoFactory();
IAcciones habilidad2 = seleccionar.Seleccionar();
seleccionar.Actividad();

seleccionar = new RanaFactory();
IAcciones habilidad3 = seleccionar.Seleccionar();
seleccionar.Actividad();