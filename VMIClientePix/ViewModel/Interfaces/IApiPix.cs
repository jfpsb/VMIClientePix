using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMIClientePix.Model;

namespace VMIClientePix.ViewModel.Interfaces
{
    public interface IApiPix
    {
        object Credenciais();
        Cobranca CriarCobranca();
        Cobranca GetCobrancaApi(string txid);
        QRCode GetQrCode(string locId);
    }
}
