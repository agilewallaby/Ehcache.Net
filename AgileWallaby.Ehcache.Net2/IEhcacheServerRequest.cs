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

namespace AgileWallaby.Ehcache
{
    internal interface IEhcacheServerRequest
    {
        string GetElement(string cache, string key, out string contentType);
        void PutElement(string cache, string key, string serializedValue, string contentType, int? timeToLive = null);
        int Timeout { get; set; }
        int GetCount(string cache);
        bool Contains(string cache, string key);
        object Remove(string cache, string key);
    }
}