#region License
/* ***** BEGIN LICENSE BLOCK *****
 * Version: MPL 1.1
 *
 * The contents of this file are subject to the Mozilla Public License Version
 * 1.1 (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * The Original Code is Ehcache .Net Wrapper..
 *
 * The Initial Developer of the Original Code is
 * James Webster.
 * Portions created by the Initial Developer are Copyright (C) 2010
 * the Initial Developer. All Rights Reserved.
 *
 * Contributor(s):
 *
 * ***** END LICENSE BLOCK ***** */
#endregion License

using System;
using System.IO;

namespace AgileWallaby.Ehcache
{
    public class XmlSerializer: ISerializer
    {
        public const string XmlContentType = "text/xml";

        public string ContentType
        {
            get { throw new NotImplementedException(); }
        }

        public T Deserialize<T>(Stream s) where T : class
        {
            throw new NotImplementedException();
        }

        public object Deserialize(Stream s)
        {
            throw new NotImplementedException();
        }

        public void Serialize<T>(Stream s, T value) where T : class
        {
            throw new NotImplementedException();
        }
    }
}