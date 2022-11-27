﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleActzAndPostz.Domain.Models.DbEntities.BaseEntity
{
    public class BaseEntity<TKey> : IEntity<TKey>
    {
        public TKey Id { get; set; }
    }

}