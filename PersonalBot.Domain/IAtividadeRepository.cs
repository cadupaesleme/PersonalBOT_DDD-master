﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBot.Domain
{
   public interface IAtividadeRepository
    {
        
        List<Atividade> GetAtividades();
    }
}
