﻿namespace Falzoni.Presentation.Administrator.Models.Tables.Base
{
    public class TableBase
    {
        public int draw { get; set; } = 1;

        public int recordsTotal { get; set; }

        public int recordsFiltered { get; set; }

        public string error { get; set; }

    }
}