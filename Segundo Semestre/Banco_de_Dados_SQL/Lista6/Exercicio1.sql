-- a)

SELECT C.nom_corretor
FROM CORRETOR C
JOIN ATENDE A ON C.id_corretor = A.id_corretor
GROUP BY C.id_corretor, C.nom_corretor
HAVING COUNT(A.id_regiao) >= 2;


-- b)

SELECT R.nom_regiao, M.nom_municipio, COUNT(A.id_corretor) AS total_corretores
FROM REGIAO R
LEFT JOIN MUNICIPIO M ON R.id_municipio = M.id_municipio
LEFT JOIN ATENDE A ON R.id_regiao = A.id_regiao
GROUP BY R.id_regiao, R.nom_regiao, M.nom_municipio;


-- c)

SELECT C.nom_corretor
FROM CORRETOR C
JOIN TELEFONE T ON C.id_corretor = T.id_corretor
LEFT JOIN ATENDE A ON C.id_corretor = A.id_corretor
WHERE A.id_corretor IS NULL;


-- d)

SELECT C.nom_corretor, R.nom_regiao
FROM CORRETOR C
JOIN ATENDE A ON C.id_corretor = A.id_corretor
JOIN REGIAO R ON A.id_regiao = R.id_regiao
JOIN MUNICIPIO M ON R.id_municipio = M.id_municipio
WHERE M.nom_municipio = 'Belo Horizonte';


-- e)

SELECT C.nom_corretor
FROM CORRETOR C
JOIN TELEFONE T ON C.id_corretor = T.id_corretor
GROUP BY C.id_corretor, C.nom_corretor
HAVING COUNT(T.id_telefone) >= 2;


-- f)

SELECT C.nom_corretor
FROM CORRETOR C
JOIN ATENDE A ON C.id_corretor = A.id_corretor
LEFT JOIN TELEFONE T ON C.id_corretor = T.id_corretor
WHERE T.id_corretor IS NULL;


-- g)

SELECT C.nom_corretor, R.nom_regiao
FROM CORRETOR C
JOIN ATENDE A ON C.id_corretor = A.id_corretor
JOIN REGIAO R ON A.id_regiao = R.id_regiao
JOIN MUNICIPIO M ON R.id_municipio = M.id_municipio
WHERE M.sig_uf = 'MG';
