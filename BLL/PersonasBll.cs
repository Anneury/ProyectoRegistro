using ProyectoRegistro.Entidades;
using ProyectoRegistro.DAL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProyectoRegistro.BLL
{
    public class PersonasBll
    {
        public static bool Guardar(Personas personas)
        {
            if (!Existe(personas.PersonaID))
                return Insertar(personas);
            else
                return Modificar(personas);
        }    
        private static bool Insertar(Personas personas)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Personas.Add(personas);
                paso = contexto.SaveChanges() > 0;
            
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }
        public static bool Modificar(Personas personas)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(personas).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var personas = contexto.Personas.Find(id);

                if(personas != null)
                {
                    contexto.Personas.Remove(personas);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static Personas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Personas personas;

            try
            {
                personas = contexto.Personas.Find(id);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return personas;
        }
        
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Personas.Any(e => e.PersonaID == id);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }
    }


}
