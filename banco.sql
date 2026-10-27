-- =====================================================
-- SGL - Sistema de Gerenciamento de Logística
-- Script de criação do banco de dados (somente estrutura)
-- Compatível com MySQL 8 e MariaDB 10.4+
-- =====================================================

CREATE DATABASE IF NOT EXISTS projeto_logistica
  DEFAULT CHARACTER SET utf8mb4
  COLLATE utf8mb4_general_ci;

USE projeto_logistica;

-- Usuários do sistema (a senha é guardada como hash PBKDF2, nunca em texto)
CREATE TABLE IF NOT EXISTS usuario (
  usuarioID INT NOT NULL AUTO_INCREMENT,
  nome VARCHAR(100) NOT NULL,
  login VARCHAR(50) NOT NULL,
  senha VARCHAR(100) NOT NULL,
  ativo TINYINT(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (usuarioID),
  UNIQUE KEY login (login)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS veiculo (
  veiculoID INT NOT NULL AUTO_INCREMENT,
  modelo VARCHAR(100) NOT NULL,
  placa VARCHAR(7) NOT NULL,
  consumo_medio DECIMAL(4,2) NOT NULL,
  carga_maxima DECIMAL(7,2) DEFAULT NULL,
  PRIMARY KEY (veiculoID),
  UNIQUE KEY placa (placa)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS motorista (
  motoristaID INT NOT NULL AUTO_INCREMENT,
  nome VARCHAR(100) NOT NULL,
  cnh VARCHAR(11) NOT NULL,
  telefone VARCHAR(11) NOT NULL,
  cep VARCHAR(8) DEFAULT NULL,
  logradouro VARCHAR(150) DEFAULT NULL,
  bairro VARCHAR(100) DEFAULT NULL,
  cidade VARCHAR(100) DEFAULT NULL,
  uf CHAR(2) DEFAULT NULL,
  PRIMARY KEY (motoristaID),
  UNIQUE KEY cnh (cnh)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS rota (
  rotaID INT NOT NULL AUTO_INCREMENT,
  origem VARCHAR(100) NOT NULL,
  destino VARCHAR(150) NOT NULL,
  distancia DECIMAL(8,2) NOT NULL,
  PRIMARY KEY (rotaID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS preco_combustivel (
  precoID INT NOT NULL AUTO_INCREMENT,
  combustivel VARCHAR(100) NOT NULL,
  preco DECIMAL(4,2) NOT NULL,
  data_consulta DATETIME NOT NULL,
  PRIMARY KEY (precoID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Viagem depende de veiculo, motorista e rota (por isso é criada por último)
CREATE TABLE IF NOT EXISTS viagem (
  viagemID INT NOT NULL AUTO_INCREMENT,
  veiculoID INT NOT NULL,
  motoristaID INT NOT NULL,
  rotaID INT NOT NULL,
  data_saida DATETIME NOT NULL,
  data_chegada DATETIME DEFAULT NULL,
  situacao VARCHAR(30) NOT NULL,
  PRIMARY KEY (viagemID),
  KEY veiculoID (veiculoID),
  KEY motoristaID (motoristaID),
  KEY rotaID (rotaID),
  CONSTRAINT viagem_ibfk_1 FOREIGN KEY (veiculoID) REFERENCES veiculo (veiculoID),
  CONSTRAINT viagem_ibfk_2 FOREIGN KEY (motoristaID) REFERENCES motorista (motoristaID),
  CONSTRAINT viagem_ibfk_3 FOREIGN KEY (rotaID) REFERENCES rota (rotaID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
