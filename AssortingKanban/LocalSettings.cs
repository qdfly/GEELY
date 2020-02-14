using System;

namespace AssortingKanban
{
    /// <summary>
    /// �������á�
    /// </summary>
    [Serializable]
    public class LocalSettings
    {
        /// <summary>
        /// ��ȡ�����÷����� IP��
        /// </summary>
        public string ServerIP { get; set; }

        /// <summary>
        /// ��ȡ�����÷���˿ڡ�
        /// </summary>
        public int ServicePort { get; set; }

        /// <summary>
        /// ��ȡ�����������ּ�ڵı��롣
        /// </summary>
        public string CfgChannelCode { get; set; }

        /// <summary>
        /// ��ʼ���������á�
        /// </summary>
        public LocalSettings()
        {
            this.ServerIP = "localhost";
            this.ServicePort = 5980;
        }
    }
}