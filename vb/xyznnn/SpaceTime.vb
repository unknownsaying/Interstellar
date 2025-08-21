Function XYZ
class X1Y1Z1
sub X1
    for ( i = 0; i <= 3; ++i)
        for( j = 0; i <= 3; ++j)
            for( k = 0; k <= 3; ++k)
        continue
end sub
sub Y1
    for( l = 0;-3 <= l && l <= 3; ++l || --l)
       for( m = 0;-3 <= m && m <= 3 ;++m || --m)
          for( n = 0 ;-3 <= n && n <= 3;++n || --n)
        break
end sub
sub Z1
    for( o = 0;o >= -3;o--)
        for( p = 0; p >= -3;p--)
            for( q = 0; q >= -3; q--)
        continue
end sub

class X2Y2Z2
sub X2
    for ( i = 0; i <= 6; ++i)
        for ( j = 0; j <= 6; ++j)
            for ( k = 0; k <= 6; ++k)
        continue
end sub
sub Y2
    for ( l = 0; l <= -6 || l >= 6; l++ || --l)
        for ( m = 0; m <= -6 && m >= 6; m++ || --m)
            for ( n = 0; n <= -6 && n >= 6; n++ || --n)
        break
end sub
sub Z2
    for ( o = 0; o >= -6; o--)
        for ( p = 0; p >= -6; p--)
            for ( q = 0; q >= -6; q--)
        continue
end sub

class X3Y3Z3
sub X3
    for ( i = 0; i <= 9; i++)
        for ( j = 0; j <= 9; j++)
            for ( k = 0; k <= 9; k++)
        continue
end sub
sub Y3
    for ( l = 0;l <= -9 && l >= 9; l++ || l--)
        for( m = 0;m <= -9 && m >= 9;m++ || m--)
            for( n = 0;n <= -9 && n >= 9;n++ || n--)
        break
end sub
sub Z3
    for ( o = 0; o >= -9; o--)
        for ( p = 0; p >= -9; p--)
            for ( q = 0; q >= -9; q--)
        continue
end sub

class X4Y4Z4
sub X4
    for ( I = 0; I <= 2; I++)
        for( J = 0; J <= 2; J++)
            for( K = 0; K <= 2; K++)
        break
end sub
sub Y4
    for( L = 0;-2 <= L &&  L <= 2; L++ || --L)
        for( M = 0;-2 <= M && M <= 2;M++ || --M)
            for( N = 0;-2 <= N && N <= 2; N++ || --N) 
        continue       
end sub
sub Z4
    for ( O = 0; O >= -2; --O)
        for ( P = 0; P >= -2; --P)
            for ( Q = 0; Q >= -2; --Q)
        break
end sub

class X5Y5Z5
sub X5
    for ( I = 0; I <= 4; ++I)
       for ( J = 0; J <= 4; ++J)
          for ( K = 0; K <= 4; ++K)
        break

sub Y5
    for ( L = 0; L <= -4 && L <= 4; ++L || L--)
        for ( M = 0; M <= -4 && M <= 4; ++M || M--)
            for ( N = 0; N <= -4 && N <= 4; ++N || N--)
        continue

sub Z5
    for ( O = 0; O >= -4; O--)
       for ( P = 0; P >= -4; P--)
          for ( Q = 0; Q >= -4; Q--)
        break
end sub
End Function
class X6Y6Z6
sub X6
    for ( I = 0; I <= 8; I++)
        for( J = 0; J <= 8; J++)
            for( K = 0; K <= 8; K++)
        break
end sub
sub Y6 
    for( L = 0;-8 <= L && L <= 8; L++ || L--)
        for( M = 0;-8 <= M && M <= 8;M++ || M--)
            for( N = 0;-8 <= N && N <= 8; N++ || N--)
        continue
end sub
sub Z6
    for( O = 0; O >= -8; --O)
        for( P = 0; P >= -8; --P)
            for( Q  = 0; Q >= -8; --Q)
        break
end sub

Function Time
Class t1t2 
sub   t1
Return
       'a * sin(N + t1)' + 'b * cos(N - t1)',
       'c * sin(N - t1)' + 'd * cos(N + t1)'
end sub  
      t2
Return
       'A * sin(0 + t2)' + 'B * cos(0 - t2)',
       'C * sin(0 - t2)' + 'D * cos(0 + t2)'
end Class
Class t3t4
sub   t3
Return
       'e % asin(N + t3)' + 'f % acos(N - t3)',
       'g % asin(N - t3)' + 'h % acos(N + t3)'
end sub
sub   t4
Return
       'E % asin(0 + t4)' + 'F % acos(0 - t4)',
       'G % asin(0 - t4)' + 'H % acos(0 + t4)'
end sub
end Class
Class t5t6
sub   t5
Return
       'i / tan(N + t5)' + 'j / atan(N - t5)',
       'k / tan(N - t5)' + 'l / atan(N + t5)'
sub   t6
Return
       'I / tan(0 + t6)' + 'J / atan(0 - t6)',
       'K / tan(0 - t6)' + 'L / atan(0 + t6)'
Class t7t8
sub   t7
Return
       'm :: sh(N + t7)' + 'n :: ch(N - t7)',
       'o :: sh(N - t7)' + 'p :: ch(N + t7)'
end sub
sub   t8
Return
        'm :: sh(0 + t8)' + 'n :: ch(0 - t8)',
        'o :: sh(0 - t8)' + 'p :: ch(0 + t8)'
end sub
Class t9t10
sub   t9
Return
       'r & ceil(N + t9)' + 's & floor(N - t9)',
       't & floor(N - t9)' + 'uv & ceil(N + t9)'
end sub
sub   t10
Return
       'R & ceil(0 + t10)' + 'S & floor(0 - t10)',
       'T & floor(0 - t10)' + 'UV & ceil(0 + t10)'
end sub
end Class
Class t11t0
sub   t11
Return
       'w ^ exp(N + t11)' + 'x ^ log(N - t11)',
       'y ^ exp(N - t11)' + 'z ^ log(N + t11)'
end sub
sub   t0
Return
       'W ^ exp(0 + t0)' + 'X ^ log(0 - t0)',
       'Y ^ exp(0 - t0)' + 'Z ^ log(0 + t0)'
end sub
End Function