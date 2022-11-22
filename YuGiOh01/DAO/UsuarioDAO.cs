using System;

namespace YuGiOh01.DAO
{
    public class UsuarioDAO
    {
        internal static void CadastrarUsuario(Usuario user)
        {
			try
			{
				using(var ctx = new YuGiOhBDEntities())
				{
					ctx.Usuarios.Add(user);
					ctx.SaveChanges();
				}
			}
			catch (Exception ex)
			{

			}
        }
    }
}