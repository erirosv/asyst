namespace BusinessEntities_FrameWork.Models
    // Definierar vad det är som skall skickas till facaden
{
    public interface IGruppskidlektion
    {
        int Antaldeltagare { get; set; }
        string Färg { get; set; }
        int GruppskidlektionsID { get; set; }
        string Lärare { get; set; }
        bool Status { get; set; }
    }
}