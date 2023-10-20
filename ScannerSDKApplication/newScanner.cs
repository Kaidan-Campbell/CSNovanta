﻿using CSProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleApplication
{
    public class newScanner : Scanner
    {
        public newScanner()
        {
            FirmwareRecordCount = 0;
            FirmwareCurrectRecord = 0;
            Status = "Available";
        }
        int m_FirmwareRecordCount;

        public int FirmwareRecordCount
        {
            get { return m_FirmwareRecordCount; }
            set { m_FirmwareRecordCount = value; }
        }
        int m_FirmwareCurrectRecord;

        public int FirmwareCurrectRecord
        {
            get { return m_FirmwareCurrectRecord; }
            set { m_FirmwareCurrectRecord = value; }
        }
        string m_Status;

        public string Status
        {
            get { return m_Status; }
            set { m_Status = value; }
        }
    }
}
