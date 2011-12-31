﻿/*
  
  Version: MPL 1.1/GPL 2.0/LGPL 2.1

  The contents of this file are subject to the Mozilla Public License Version
  1.1 (the "License"); you may not use this file except in compliance with
  the License. You may obtain a copy of the License at
 
  http://www.mozilla.org/MPL/

  Software distributed under the License is distributed on an "AS IS" basis,
  WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
  for the specific language governing rights and limitations under the License.

  The Original Code is the Open Hardware Monitor code.

  The Initial Developer of the Original Code is 
  Michael Möller <m.moeller@gmx.ch>.
  Portions created by the Initial Developer are Copyright (C) 2011
  the Initial Developer. All Rights Reserved.

  Contributor(s):

  Alternatively, the contents of this file may be used under the terms of
  either the GNU General Public License Version 2 or later (the "GPL"), or
  the GNU Lesser General Public License Version 2.1 or later (the "LGPL"),
  in which case the provisions of the GPL or the LGPL are applicable instead
  of those above. If you wish to allow use of your version of this file only
  under the terms of either the GPL or the LGPL, and not to allow others to
  use your version of this file under the terms of the MPL, indicate your
  decision by deleting the provisions above and replace them with the notice
  and other provisions required by the GPL or the LGPL. If you do not delete
  the provisions above, a recipient may use your version of this file under
  the terms of any one of the MPL, the GPL or the LGPL.
 
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenHardwareMonitor.Hardware.HDD {

#if DEBUG

  internal class DebugSmart : ISmart {

    private Drive[] drives = {
      new Drive("KINGSTON SNV425S264GB", 16,
        @" 01 000000000000 100 100      
           02 000000000000 100 100      
           03 000000000000 100 100      
           05 000000000000 100 100      
           07 000000000000 100 100      
           08 000000000000 100 100      
           09 821E00000000 100 100      
           0A 000000000000 100 100      
           0C 950200000000 100 100      
           A8 000000000000 100 100      
           AF 000000000000 100 100      
           C0 000000000000 100 100      
           C2 290014002B00 100 41       
           C5 000000000000 100 100      
           F0 000000000000 100 100      
           AA 07007B000000 100 100      
           AD 0E1E71304919 100 100"),

      new Drive("PLEXTOR  PX-128M2S", 16, 
        @" 01 000000000000 100 100 0   
           03 000000000000 100 100 0   
           04 000000000000 100 100 0   
           05 000000000000 100 100 0   
           09 250100000000 100 100 0   
           0A 000000000000 100 100 0   
           0C D10000000000 100 100 0   
           B2 000000000000 100 100 0   
           BB 000000000000 100 100 0   
           BE 000000000000 100 100 0   
           C0 000000000000 100 100 0   
           C1 000000000000 100 100 0   
           C2 000000000000 100 100 0   
           C3 000000000000 100 100 0   
           C5 000000000000 100 100 0   
           C6 000000000000 100 100 0   
           C7 000000000000 100 100 0"),

      new Drive("OCZ-VERTEX2", 16, 
        @" 01 DADAD5000000 100 106 50
           05 000000000000 100 100 3 
           09 DF0900004A2F 100 100 0 
           0C FC0100000000 100 100 0 
           AB 000000000000 0   0   0 
           AC 000000000000 0   0   0 
           AE 1F0000000000 0   0   0 
           B1 000000000000 0   0   0 
           B5 000000000000 0   0   0 
           B6 000000000000 0   0   0 
           BB 000000000000 100 100 0 
           C2 010081007F00 129 1   0 
           C3 DADAD5000000 100 106 0 
           C4 000000000000 100 100 0 
           E7 000000000000 100 100 10
           E9 800400000000 0   0   0 
           EA 000600000000 0   0   0 
           F1 000600000000 0   0   0 
           F2 801200000000 0   0   0"),
      
      new Drive("WDC WD5000AADS-00S9B0", 10, 
        @" 1   000000000000 200 200         
           3   820D00000000 149 150         
           4   610800000000 98  98          
           5   000000000000 200 200         
           7   000000000000 253 100         
           9   0F1F00000000 90  90          
           10  000000000000 100 100         
           11  000000000000 100 100         
           12  880200000000 100 100         
           192 6B0000000000 200 200         
           193 E9CB03000000 118 118         
           194 280000000000 94  103         
           196 000000000000 200 200         
           197 000000000000 200 200         
           198 000000000000 200 200         
           199 000000000000 200 200         
           200 000000000000 200 200         
           130 7B0300010002 1   41          
           5   000000000000 0   0           
           1   000000000000 0   0"),

      new Drive("INTEL SSDSA2M080G2GC", 10, 
        @" 3   000000000000 100 100         
           4   000000000000 100 100         
           5   010000000000 100 100         
           9   B10B00000000 100 100         
           12  DD0300000000 100 100         
           192 480000000000 100 100         
           225 89DB00000000 200 200         
           226 3D1B00000000 100 100         
           227 030000000000 100 100         
           228 7F85703C0000 100 100         
           232 000000000000 99  99          
           233 000000000000 98  98          
           184 000000000000 100 100         
           1   000000000000 0   0"),

      new Drive("OCZ-VERTEX", 10, 
        @" 1   000000000000 0   8   
           9   000000000000 30  99  
           12  000000000000 0   15  
           184 000000000000 0   7   
           195 000000000000 0   0   
           196 000000000000 0   2   
           197 000000000000 0   0   
           198 B9ED00000000 214 176 
           199 352701000000 143 185 
           200 B10500000000 105 55  
           201 F40A00000000 238 194 
           202 020000000000 137 35  
           203 020000000000 125 63  
           204 000000000000 0   0   
           205 000000000000 19  136 
           206 000000000000 22  54  
           207 010000000000 113 226 
           208 000000000000 49  232 
           209 000000000000 0   98  
           211 000000000000 0   0   
           212 000000000000 0   0   
           213 000000000000 0   0"),
 
      new Drive("INTEL SSDSA2CW120G3", 16,
        @"03 000000000000 100 100 0
          04 000000000000 100 100 0
          05 000000000000 100 100 0
          09 830200000000 100 100 0
          0C 900100000000 100 100 0
          AA 000000000000 100 100 0
          AB 000000000000 100 100 0
          AC 000000000000 100 100 0
          B8 000000000000 100 100 0
          BB 000000000000 100 100 0
          C0 040000000000 100 100 0
          E1 FF4300000000 100 100 0
          E2 E57D14000000 100 100 0
          E3 000000000000 100 100 0
          E4 E39600000000 100 100 0
          E8 000000000000 100 100 0
          E9 000000000000 100 100 0
          F1 FF4300000000 100 100 0
          F2 264F00000000 100 100 0")
      };

    public IntPtr OpenDrive(int driveNumber) {
      if (driveNumber < drives.Length)
        return (IntPtr)driveNumber;
      else
        return InvalidHandle;
    }

    public bool EnableSmart(IntPtr handle, int driveNumber) {
      if (handle != (IntPtr)driveNumber)
        throw new ArgumentOutOfRangeException();

      return true;
    }

    public DriveAttributeValue[] ReadSmartData(IntPtr handle, int driveNumber) {
      if (handle != (IntPtr)driveNumber)
        throw new ArgumentOutOfRangeException();

      return drives[driveNumber].DriveAttributeValues;
    }

    public DriveThresholdValue[] ReadSmartThresholds(IntPtr handle, 
      int driveNumber) 
    {
      if (handle != (IntPtr)driveNumber)
        throw new ArgumentOutOfRangeException();

      return drives[driveNumber].DriveThresholdValues;
    }

    public string ReadName(IntPtr handle, int driveNumber) {
      if (handle != (IntPtr)driveNumber)
        throw new ArgumentOutOfRangeException();

      return drives[driveNumber].Name;
    }

    public void CloseHandle(IntPtr handle) { }


    private class Drive {

      public Drive(string name, int idBase, string value) {
        this.Name = name;

        string[] lines = value.Split(new[] { '\r', '\n' }, 
          StringSplitOptions.RemoveEmptyEntries);

        DriveAttributeValues = new DriveAttributeValue[lines.Length];
        List<DriveThresholdValue> thresholds = new List<DriveThresholdValue>();

        for (int i = 0; i < lines.Length; i++) {

          string[] array = lines[i].Split(new[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);

          if (array.Length != 4 && array.Length != 5)
            throw new Exception();

          DriveAttributeValue v = new DriveAttributeValue();
          v.Identifier = Convert.ToByte(array[0], idBase);

          v.RawValue = new byte[6];
          for (int j = 0; j < 6; j++) {
            v.RawValue[j] = Convert.ToByte(array[1].Substring(2 * j, 2), 16);
          }

          v.WorstValue = Convert.ToByte(array[2], 10);
          v.AttrValue = Convert.ToByte(array[3], 10);

          DriveAttributeValues[i] = v;

          if (array.Length == 5) {
            DriveThresholdValue t = new DriveThresholdValue();
            t.Identifier = v.Identifier;
            t.Threshold = Convert.ToByte(array[4], 10);
            thresholds.Add(t);
          }
        }

        DriveThresholdValues = thresholds.ToArray();
      }

      public DriveAttributeValue[] DriveAttributeValues { get; private set; }

      public DriveThresholdValue[] DriveThresholdValues { get; private set; }

      public string Name { get; private set; }
    }

    public IntPtr InvalidHandle { get { return (IntPtr)(-1); } }
  }

#endif

}
