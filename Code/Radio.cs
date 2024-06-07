using Microsoft.AspNetCore.Components;

namespace GiacomoRadios.Code
{
    public class Radio
    {
        // Radio Propriety
        public String Id { get; set; }
        public String Title { get; set; }
        public String UrlAudio { get; set; }
        public String Genere { get; set; }
        public String ImgIcona { get; set; }

        // Radio Constructor
        public Radio(String id, String title, String urlAudio, String genere, String ImgIcona)
        {
            this.Id = id;
            this.Title = title;
            this.UrlAudio = urlAudio;
            this.Genere = genere;
            this.ImgIcona = ImgIcona;
        }
        public Radio(String id, String title)
        {
            this.Id = id;
            this.Title = title;
        }

        // Radio Default final Constructor
        public Radio()
        {
            this.Id = "0";
            this.Title = "x";
            this.UrlAudio = "x";
            this.Genere = "x";
            this.ImgIcona = "x";
        }
    }
}
