using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Entities;
using Business.Logic;
using Data.Database;

namespace Business.Logic
{
   public class UsuarioLogic: BusinessLogic
    {
       public UsuarioLogic() 
       {
           UsuarioData = new Data.Database.UsuarioAdapter();

       }

       private Data.Database.UsuarioAdapter _usuarioData;
       public Data.Database.UsuarioAdapter UsuarioData
       {
           get { return _usuarioData; }
           set { _usuarioData = value; }

       }


        # region METODOS

       public List<Usuario> GetAll()
       {
           return UsuarioData.GetAll();
       }

       public Business.Entities.Usuario GetOne(int ID)
       {

           return UsuarioData.GetOne(ID);

       }

       public void Delete(int ID)
       {
           UsuarioData.Delete(ID);
       }

       public void Save(Business.Entities.Usuario usu)
       {
           UsuarioData.Save(usu);
       }

       public void Update(Business.Entities.Usuario usu)
       {
           //UsuarioData.Update(usu);
       }

        #endregion 
    }
}
