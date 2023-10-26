using Microsoft.EntityFrameworkCore;


namespace AccesoDatos
{
    // Se define el contexto de conexión a base de datos, que después
    // será instanciado como servicio para cada sesión https de usuario.
    public class Contexto : DbContext
    {
        // Se define un constructor que nos permita generar el contexto
        // como servicio desde el contenedor de servicios de la sesión https
        // de usuario.
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        // Aseguramos el uso de Ids autoincrementales.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
        // Los DbSet definen las operaciones básicas contra cada
        // entidad de base de datos (CRUD).
        // En los DbSet se definen colecciones de las clases definidas
        // en Acceso.cs, lo que nos daría las entidades de la base de datos.
        public DbSet<Acceso> Accesos { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<AutorLibro> Rel_Autores_Libros { get; set; }
        public DbSet<Coleccion> Colecciones { get; set; }
        public DbSet<Editorial> Editoriales { get; set; }
        public DbSet<EstadoPrestamo> Estados_Prestamos { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}