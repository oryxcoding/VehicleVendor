using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Oxide.Plugins
{
    public class VehicleVendor : RustPlugin
    {
        #region Fields
        private readonly string _permission = "vechilevendor.allow";
        #endregion

        #region Chat Command
        [ChatCommand("buy")]
        private void cmdVechileVendor(BasePlayer player, string cmd, string[] args)
        {
            if(!permission.UserHasPermission(player.UserIDString, _permission))
            {
                return;
            }
        }
        #endregion

        #region Methods

        private void Send(BasePlayer player, string key)
        {
            SendReply(player, "<color=#154eab>[</color><color=#b9e1ed>VehicleVendor</color><color=#154eab>]</color>" + lang.GetMessage(key, this));
        }
        #endregion

        #region Localzation

        #endregion
    }
}
