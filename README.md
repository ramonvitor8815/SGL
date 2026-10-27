# SGL – Sistema de Gerenciamento de Logística

Sistema desktop em **C# (Windows Forms, .NET Framework 4.7.2)** com banco **MySQL**, para controlar veículos, motoristas, rotas, preço de combustível e viagens.

## Funcionalidades

- **Login** com senha protegida (hash PBKDF2) e **cadastro de usuários**.
- **CRUD** (salvar, editar, consultar e excluir) de **Veículo, Motorista, Rota, Preço do Combustível e Viagem**.
- Botão **Novo** em cada aba: limpa os campos e mostra o próximo ID.
- **Pesquisa** em tempo real acima de cada lista.
- **Consulta de viagens** com filtros por status e data de saída, e **cálculo do custo estimado de combustível**:
  `custo = (distância ÷ consumo médio) × preço mais recente do combustível`.
- **Busca de endereço pelo CEP** (ViaCEP) no cadastro do motorista.
- **Distância da rota calculada automaticamente** a partir da origem e do destino (Photon + OSRM).
- Validações com aviso visual nos campos, tema de cores automático e janela redimensionável.
- Botão **Sair** que volta para a tela de login.

## Tecnologias

- C# / Windows Forms (.NET Framework 4.7.2) – Visual Studio
- MySQL (testado também com MariaDB 10.4) – biblioteca `MySql.Data`
- APIs públicas: ViaCEP, Photon (geocodificação) e OSRM (rotas)

## Como executar

1. **Crie o banco de dados:** abra o MySQL Workbench (ou outro cliente), execute o arquivo [`banco.sql`](banco.sql).
2. **Configure a conexão:** abra `SGL/Conexao.cs` e troque `SUA_SENHA` pela senha do seu MySQL (usuário `root`, servidor `localhost`, porta `3306`, se for diferente ajuste também).
3. Abra `SGL.sln` no **Visual Studio**. Os pacotes NuGet são restaurados automaticamente.
4. Compile (`Ctrl+Shift+B`) e execute (`F5`).
5. Na tela de login, clique em **Cadastrar** para criar o primeiro usuário e depois entre com ele.

> A distância automática e a busca de CEP precisam de internet. Sem internet, digite o Km manualmente.

## Estrutura do banco

| Tabela | Descrição |
|---|---|
| `usuario` | Usuários do sistema (login e senha com hash) |
| `veiculo` | Modelo, placa, consumo médio (Km/L) e carga máxima |
| `motorista` | Nome, CNH, telefone e endereço |
| `rota` | Origem, destino e distância (Km) |
| `preco_combustivel` | Combustível, preço e data da consulta |
| `viagem` | Veículo, motorista, rota, datas de saída/chegada e situação |

## Observação sobre segurança

A senha do banco **não** deve ser enviada ao GitHub. No repositório, o `Conexao.cs` usa `SUA_SENHA`.
