using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemPedidosComposicao.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayments = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
