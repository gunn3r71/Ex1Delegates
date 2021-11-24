# Ex1Delegates

Crie um delegate chamado Filter, que pode referenciar métodos que recebem um int como 
parâmetro e retornam um bool. 
Depois, crie um método chamado FilterList(), que recebe como parâmetro uma lista de 
números inteiros e um delegate Filter. Este método deve invocar o delegate Filter em cada 
um dos elementos e, no final, retornar uma nova lista. Esta nova lista conterá apenas os 
elementos cujo retorno do delegate for true. 
Para testar o método FilterList(), crie uma lista de números de 0 a 10. Depois crie dois 
métodos que poderão ser referenciados pelo delegate. O primeiro método é o 
FilterGreatedThan5(), que deve retornar na nova lista apenas os números maiores do que 
5. O segundo método é o FilterOdd(), que deve retornar na nova lista apenas os números
ímpares. 
