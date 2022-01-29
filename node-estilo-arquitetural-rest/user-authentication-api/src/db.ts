import { Pool } from "pg";

const connectionString = "link/endereço do banco de dados"; 

const db = new Pool({ connectionString });

export default db;