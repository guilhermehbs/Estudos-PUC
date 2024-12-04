-- a)

SELECT D.num_conta, A.nom_agencia
FROM DEPOSITANTE D
JOIN CONTA C ON D.num_conta = C.num_conta
JOIN AGENCIA A ON C.id_agencia = A.id_agencia
GROUP BY D.num_conta, A.nom_agencia
HAVING COUNT(D.id_cliente) > 1;


-- b)

SELECT C.sig_uf, C.nom_cidade, COUNT(DISTINCT D.id_cliente) AS total_clientes
FROM CLIENTE C
LEFT JOIN DEPOSITANTE D ON C.id_cliente = D.id_cliente
GROUP BY C.sig_uf, C.nom_cidade;


-- c)

SELECT C.num_conta, C.saldo
FROM CONTA C
LEFT JOIN EMPRESTIMO E ON C.num_conta = E.num_conta
WHERE E.num_emprestimo IS NULL;


-- d)

SELECT C.num_conta, C.saldo, A.nom_agencia
FROM CONTA C
JOIN AGENCIA A ON C.id_agencia = A.id_agencia
WHERE A.nom_cidade = 'Belo Horizonte';


-- e)

SELECT C.num_conta, A.nom_agencia
FROM CONTA C
JOIN EMPRESTIMO E ON C.num_conta = E.num_conta
JOIN AGENCIA A ON C.id_agencia = A.id_agencia
GROUP BY C.num_conta, A.nom_agencia
HAVING COUNT(E.num_emprestimo) >= 2;


-- f)

SELECT C.num_conta, A.nom_agencia
FROM CONTA C
JOIN EMPRESTIMO E ON C.num_conta = E.num_conta
JOIN AGENCIA A ON C.id_agencia = A.id_agencia
GROUP BY C.num_conta, A.nom_agencia
HAVING COUNT(E.num_emprestimo) >= 2;


-- g)

SELECT C.num_conta, C.saldo
FROM CONTA C
LEFT JOIN EMPRESTIMO E ON C.num_conta = E.num_conta
WHERE YEAR(E.data) <> 2022 OR E.num_emprestimo IS NULL;


-- h)

SELECT C.num_conta, C.saldo, A.nom_agencia
FROM CONTA C
JOIN AGENCIA A ON C.id_agencia = A.id_agencia
WHERE A.sig_uf = 'SP';
