using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica04092017.Models
{
    public class MateriaServicio
    {
        public List<Materia> lista = new List<Materia>();
        public static List<Materia> Items;

        // todo lo que es publico empieza en mayuscula 
        // constructor estatico 
        static MateriaServicio() {
            Items = new List<Materia>();
            Items.Add(new Materia()
            {
                idMateria = 1,
                nombre = "Progracion web 3",
                cantidadAlumnos = 10
            });
            Items.Add(new Materia()
            {
                idMateria = 2,
                nombre = "Progracion basica",
                cantidadAlumnos = 20
            });
            Items.Add(new Materia()
            {
                idMateria = 3,
                nombre = "Base de datos",
                cantidadAlumnos = 30
            });

        }



        /*
        public List<Materia> getAll()
        {
            List<Materia> materias = new List<Materia>
            {
                new Materia {   idMateria = 1,
                                nombre = "matematica",
                                cantidadAlumnos = 5
                            },
                new Materia {   idMateria = 2,
                                nombre = "ingles",
                                cantidadAlumnos = 7
                            },
                new Materia {   idMateria = 3,
                                nombre = "literatura",
                                cantidadAlumnos = 3
                            }

            };

            return materias;
        }
        */

        public List<Materia> getAll()
        {
            List<Materia> materias = Items;

            return materias;
        }

        internal Materia obtenerPorId(int id)
        {
            Materia materiaEcontrada = null;

            foreach(Materia m in Items)
            {
                if (m.idMateria.Equals(id))
                {
                    materiaEcontrada = m;
                }
            }

            return materiaEcontrada;
        }



        public void eliminarPorId(int id)
        {
            Items.RemoveAll(m => m.idMateria == id);
        }




        internal Materia Editar(int idEntero, string nom, string cant)
        {
            
            Materia materiaEcontrada = null;

            foreach (Materia m in Items)
            {
                if (m.idMateria.Equals(idEntero))
                {
                    m.nombre.Insert(idEntero, m.nombre);

                    //Items.Insert(idEntero, m);
     
                }
            }

            return materiaEcontrada;
        }


        public void Crear( Materia m )
        {
            Items.Add(m);

        }



    }
}