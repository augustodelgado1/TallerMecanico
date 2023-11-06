﻿namespace Entidades
{
    public class Mecanico:Usuario
    {
        List<Servicio> servicios;
        EstadoDelMecanico estado;

        internal Mecanico(int id, string nombre, string email, string clave, string path = null) : 
            this(nombre, email, clave, path)
        {
            base.id = id;
        }
        public Mecanico(string nombre, string email, string clave, string path = null) : base(nombre, email, clave, Roles.Personal, path)
        {
            this.servicios = new List<Servicio>();
            this.estado = EstadoDelMecanico.Disponible;
        }

        public static bool operator +(Mecanico unMecanico, Servicio unServicio)
        {
            bool result = false;

            if (unMecanico is not null && unServicio is not null
              && unMecanico.servicios.Contains(unServicio) == false)
            {
                unMecanico.servicios.Add(unServicio);
                result = true;
            }


            return result;
        }


        public static bool operator -(Mecanico unMecanico, Servicio unServicio)
        {
            bool result = false;

            if (unMecanico is not null && unServicio is not null
              && unMecanico.servicios.Contains(unServicio) == true)
            {
                unServicio.TerminarServicio();
                result = true;
            }


            return result;
        }
        public EstadoDelMecanico Estado {
            
            get {
                this.estado = EstadoDelMecanico.Disponible;
                if (this.servicios.Find(UnServicio => UnServicio is not null && UnServicio.Estado == Servicio.EstadoDelSevicio.EnProceso) is not null)
                {
                    this.estado = EstadoDelMecanico.NoDisponible;
                }
                return this.estado;
            } 
        }

        public enum EstadoDelMecanico
        {
            Disponible,NoDisponible
        }
    }
}