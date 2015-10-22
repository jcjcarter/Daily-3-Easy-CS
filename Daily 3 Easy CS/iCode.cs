using System;

namespace Daily_3_Easy_CS
{
    interface iCode
    {

        /// <summary>
        /// Takes a unicode string and encodes it.
        /// </summary>
        /// <param name="uncoded"></param>
        /// <returns> A encoded string. </returns>
        String encode(String uncoded);

        /// <summary>
        /// Takes a coded string and decodes it.
        /// </summary>
        /// <param name="decode"></param>
        /// <returns> A decode string. </returns>
        String decode(String decode);
    }
}
