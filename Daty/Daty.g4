grammar Daty;

/*
 * Parser Rules
 */


prog: wyrazenie? ;

wyrazenie: (ddmmrrrr|mmddrrrr|rrrrmmdd|rrrrddmm|timespan) op=(PLUS|MINUS)? wyrazenie #dzialanie
			| EOF #koniec;

ddmmrrrr: (DZIEN|GODZINA|MIESIAC) SEPARATOR (MIESIAC|SLOWNIE) SEPARATOR (ROK)
          ((GODZINA|MIESIAC) SGODZ (GODZINA|MIESIAC|DZIEN|MINSEC) SGODZ (GODZINA|MIESIAC|DZIEN|MINSEC))?;

mmddrrrr: (MIESIAC|SLOWNIE) MINUS (DZIEN|GODZINA|MIESIAC) MINUS (ROK)
          ((GODZINA|MIESIAC) SGODZ (GODZINA|MIESIAC|DZIEN|MINSEC) SGODZ (GODZINA|MIESIAC|DZIEN|MINSEC))?;

rrrrmmdd: (ROK) SEPARATOR1 (MIESIAC|SLOWNIE) SEPARATOR1 (DZIEN|GODZINA|MIESIAC)
          ((GODZINA|MIESIAC) SGODZ (GODZINA|MIESIAC|DZIEN|MINSEC) SGODZ (GODZINA|MIESIAC|DZIEN|MINSEC))?;

rrrrddmm: (ROK) SEPARATOR2 (DZIEN|GODZINA|MIESIAC) SEPARATOR2 (MIESIAC|SLOWNIE)
          ((GODZINA|MIESIAC) SGODZ (GODZINA|MIESIAC|DZIEN|MINSEC) SGODZ (GODZINA|MIESIAC|DZIEN|MINSEC))?;


timespan : SPAN (MIESIAC|GODZINA|DZIEN|MINSEC|ROK|LICZBA)? SEPARATOR (GODZINA|MIESIAC) SGODZ
          (GODZINA|MIESIAC|DZIEN|MINSEC) SGODZ (GODZINA|MIESIAC|DZIEN|MINSEC) SPAN;



/*
 * Lexer Rules
 */






fragment STY : [Jj][Aa][Nn] ;
fragment LUT : [Ff][Ee][Bb] ;
fragment MAR : [Mm][Aa][Rr] ;
fragment KWI : [Aa][Pp][Rr] ;
fragment MAJ : [Mm][Aa][Yy] ;
fragment CZE : [Jj][Uu][Nn] ;
fragment LIP : [Jj][Uu][Ll] ;
fragment SIE : [Aa][Uu][Gg] ;
fragment WRZ : [Ss][Ee][Pp] ;
fragment PAZ : [Oo][Cc][Tt] ;
fragment LIS : [Nn][Oo][Vv] ;
fragment GRU : [Dd][Ee][Cc] ;

SLOWNIE: STY|LUT|MAR|KWI|MAJ|CZE|LIP|SIE|WRZ|PAZ|LIS|GRU;

SEPARATOR : [.] ;
SEPARATOR1 : [/];
SEPARATOR2 : [,];
MINUS : [-];
PLUS: [+];
SGODZ: [:];


MIESIAC: [0][0-9]|[1][0-2];
GODZINA: [1][3-9]|[2][0-4];
DZIEN: [2][5-9]|[3][0-1];
MINSEC: [3][2-9]|[4-5][0-9];
SPAN: [<>];
ROK : [6-9][0-9]|CYFRA CYFRA CYFRA|CYFRA CYFRA CYFRA CYFRA;
LICZBA: ROK|(CYFRA CYFRA CYFRA CYFRA CYFRA+);

fragment CYFRA: [0-9];


WS : [ \t\r\n]+ -> skip ;