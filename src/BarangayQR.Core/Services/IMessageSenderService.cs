using BarangayQR.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarangayQR.Core.Services;

public interface IMessageSenderService<T> where T : TextMessageBase
{
    bool Send(T message);
}
