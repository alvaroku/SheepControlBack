﻿namespace Entities
{
    public class Permission : ObjetoBase
    {
        public string Description { get; set; }
        public string Clave { get; set; }
        
        public int ControllerId { get; set; }
        public Controller Controller { get; set; }

        public int ActionId { get; set; }
        public Action Action { get; set; }
    }
}
