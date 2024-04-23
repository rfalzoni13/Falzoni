using Falzoni.Presentation.Administrator.Models.Base;
using Falzoni.Utils.Helpers;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;
using System.Web.Mvc;
using Falzoni.Presentation.Administrator.Models.Common;

namespace Falzoni.Presentation.Administrator.Models.Register
{
    public class UserModel : BaseModel
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Name { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "O e-mail é obrigatório")]
        public string Email { get; set; }

        [DisplayName("Gênero")]
        [Required(ErrorMessage = "O gênero é obrigatório")]
        public string Gender { get; set; }

        [DisplayName("Data de nascimento")]
        public DateTime DateBirth { get; set; }

        public string UserName { get; set; }

        public string PhoneNumber { get; set; }

        public string PhotoPath { get; set; }

        public string[] Roles { get; set; }



        public virtual FileModel File { get; set; }

        public virtual List<string> Perfis { get; set; }

        public virtual List<SelectListItem> Generos
        {
            get
            {
                return new List<SelectListItem>
                (
                    new SelectListItem[]
                    {
                        new SelectListItem
                        {
                            Text = "Masculino",
                            Value = "Masculino"
                        },
                        new SelectListItem
                        {
                            Text = "Feminino",
                            Value = "Feminino"
                        }
                    }
                );
            }
        }

        //Methods
        public void LoadProfilePhoto()
        {
            PhotoPath = !string.IsNullOrEmpty(PhotoPath) ? $"{UrlConfigurationHelper.PathUrl}\\{PhotoPath}" : PhotoPath;
        }

    }
}