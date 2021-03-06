﻿using SocketDA.ModelsSocket;
using SocketDA.ViewModels;
using System.Collections.ObjectModel;
using System.Net;
using System.Windows.Media;

namespace SocketDA.Models
{
    internal class UDPClientModel : MainWindowBase
    {
        /// <summary>
        /// 连接区 - 服务器信息
        /// </summary>
        public ObservableCollection<SocketUserToKen> ConnectionsInfo { get; set; }

        #region 网络配置 - Socket属性
        public ObservableCollection<IPAddress> IPAddrItemsSource { get; set; }

        private string _IPAddrText;
        public string IPAddrText
        {
            get
            {
                return _IPAddrText;
            }
            set
            {
                if (_IPAddrText != value)
                {
                    _IPAddrText = value;
                    RaisePropertyChanged(nameof(IPAddrText));
                }
            }
        }

        private int _IPAddrSelectedIndex;
        public int IPAddrSelectedIndex
        {
            get
            {
                return _IPAddrSelectedIndex;
            }
            set
            {
                if (_IPAddrSelectedIndex != value)
                {
                    _IPAddrSelectedIndex = value;
                    RaisePropertyChanged(nameof(IPAddrSelectedIndex));
                }
            }
        }

        private int _Port;
        public int Port
        {
            get
            {
                return _Port;
            }
            set
            {
                if (_Port != value)
                {
                    _Port = value;
                    RaisePropertyChanged(nameof(Port));
                }
            }
        }
        #endregion

        #region 网络配置 - 打开/关闭
        private Brush _Brush;
        public Brush Brush
        {
            get
            {
                return _Brush;
            }
            set
            {
                if (_Brush != value)
                {
                    _Brush = value;
                    RaisePropertyChanged(nameof(Brush));
                }
            }
        }

        private string _OpenClose;
        public string OpenClose
        {
            get
            {
                return _OpenClose;
            }
            set
            {
                if (_OpenClose != value)
                {
                    _OpenClose = value;
                    RaisePropertyChanged(nameof(OpenClose));
                }
            }
        }
        #endregion

        public void UDPClientDataContext()
        {
            ConnectionsInfo = new ObservableCollection<SocketUserToKen>();

            IPAddrItemsSource = new ObservableCollection<IPAddress>();
            IPAddrText = string.Empty;
            IPAddrSelectedIndex = 0;

            Port = 8088;
           
            Brush = Brushes.Red;
            OpenClose = string.Format(cultureInfo, "UDP 连接");
        }
    }
}
