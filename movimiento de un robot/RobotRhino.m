L1 = 10.25;  L2 = 9;  L3=9;  L5=6.25;

  L(1)= Link ( [0  L1    0    pi/2]);

  L(2)= Link ( [0   0    L2     0]);
  
  L(3)= Link ( [0   0    L3     0 ]);
  
  L(4)= Link ( [0   0    0    pi/2]);
  
  L(5)= Link ( [0   L5   0    0]);

  Rob=SerialLink (L)
Rob.name = 'rhino XR1';
  for th1=0:0.1:100pi
      Rob.plot ( [ th1 ,0,-17,0,0 ]);
      pause(0.001)
 end
  
  
  