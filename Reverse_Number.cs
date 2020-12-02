public int ReverseNumber(int n)
        {

            int left = n;

            int rev = 0;

            while (Convert.ToBoolean(left)) // instead of left>0 , to reverse signed numbers as well
            {
                int r = left % 10;
                rev = rev * 10 + r;
                left = left / 10;  //left = Math.floor(left / 10); 
                //return left;
                /*if (left == 0)
                {
                    return rev;
                }*/
            }

            return rev;

        }
