

-------------------------
|- Items: Queue<Item>   |
|-----------------------|
|+ CadastrarItem(Item i)|
|+ LiberarItens()		|
|+ ResgatarItens(Item i)|
|+ ListarItens()		|
|-----------------------|

-----------------------------------
|         Equipamentos         	  |
|---------------------------------|
|- eqpmts:List<Equipamento> 	  |
|---------------------------------|
|+Cadastrar(Equipamento eqp): bool|
|+Buscar(Equipamento eqpProc)     |
|+ListarEquipamentos()            |
|---------------------------------|

--------------------
|  		Item       |
|------------------|
|+ eqp: Equipamento|
|+ patrimonio: int |
|+ avarias: bool   |
|------------------|

--------------------
|     Relacao      |
|------------------|
|+ eqp: Equipamento|
|+ quantidade: int |
|------------------|
|+ DadosRelacao()  |
|------------------|

-----------------------------------
|         Locacao Contrato		  |
|---------------------------------|
|+ id: int	  					  |
|+ clienteId: int	  			  |
|+ dataEntrada: DateTime		  |
|+ dataSaida: DateTime	  		  |
|+ relacoes: List<Relacao>		  |
|+ itensDisponiveis: Stack<Item>  |
|---------------------------------|
|+ Liberar()					  |
|+ LiberarItens(List<Item> i)     |
|+ DadosContrato()            	  |
|+ DevolverItens(Equipamentos eqp)|
|+DispoItens(Equipamentos e)      |
|---------------------------------|

------------------------------------------------
|         Locacoes Contratos	  	           |
|----------------------------------------------|
|+ contrato :List<LocacaoContrato>	           |
|----------------------------------------------|
|+ Cadastrar(LocacaoContrato c)	  	           |
|+ LiberarItens(List<Item> i)    	           |
|+ DadosContrato()            	  	           |
|+IdExiste(LocacaoContrato c):bool	           |
|+ ListarContratos()     		               |
|+ ListContraLiberados(): List<LocacaoContrato>|
|+ PesquisarComFiltros(LocacaoContrato lc)     |
|+ Buscar(LocacaoContrato lc)     			   |
|----------------------------------------------|

