namespace MurilloCamachoProyecto.Models
{
    public class genero
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Boolean estado { get; set; }
        

        public ICollection<Usuario> Usuarios { get; set; }
    }
}
