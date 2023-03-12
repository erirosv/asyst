namespace BusinessEntities_FrameWork.Models

    // Definierar vad det är som skall skickas till facaden
{
    public interface IPrivatskidlektion
    {
        int Antaldeltagare { get; set; }
        string Lärare { get; set; }
        int PrivatskidlektionsID { get; set; }
        int Tid { get; set; }
    }
}