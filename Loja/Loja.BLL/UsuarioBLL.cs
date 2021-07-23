using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja.DAL;
using Loja.DTO;

namespace Loja.BLL
{
    public class UsuarioBLL
    {
        public IList<usuario_DTO> cargaUsuario()
        {
            try
            {
                return new UsuarioDAL().cargaUsuario();
            } 
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool inserirUsuario(usuario_DTO usuario)
        {
            try
            {
                return new UsuarioDAL().inserirUsuario(usuario);
            }
            catch(Exception ex)
            {
                throw ex;
            }        
        }
        
        public bool alterarUsuario(usuario_DTO usuario)
        {
            try
            {                              
                return new UsuarioDAL().alterarUsuario(usuario);
            } catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool excluirUsuario(int cod_usuario)
        {
            try
            {
                return new UsuarioDAL().excluirUsuario(cod_usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
