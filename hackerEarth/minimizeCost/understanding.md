array has [3, -1, -2]

you can select any number to redistribute, it across the array
because we're trying to minimise the array

if k = 1, 
we can subtract 3 from 3, and add 3 to the -1.
i.e the transfer array is [-3, +3, 0]

[3, -1, -2] + [-3, +3, 0] = [0, 2, -2]; so C([0, 2, -2]) = |0| + |2| + |-2| = 4;
but if k = 2, we can "spread out" the 3 over more numbers, i.e. it can reach the -2.
we can use a transfer array of [-3, +1, +2] to distribute the 3 by splitting 3 into 1 and 2
so that 
[3, -1, -2] + [-3, +1, +2] = [0, 0, 0], where C([0,0,0]) = 0;
