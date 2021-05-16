const mysql = require("sync-mysql");

const connection = new mysql({
    host: "221.163.172.198",
    user: "root",
    password: "psh11080",
    database: "Gambler"
});

module.exports = connection;