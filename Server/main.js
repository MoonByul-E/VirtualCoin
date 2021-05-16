const WebSocket = require("ws");
const Chalk = require("chalk");
const crypto = require("crypto");
const mysqlDB = require("./Mysql.js");

const loginServer = new WebSocket.Server({host: "127.0.0.1", port: 7777});
const mainServer = new WebSocket.Server({host: "127.0.0.1", port: 8888});

//서버 오픈 메세지
console.log(Chalk.magentaBright("[로그인 서버]"), "서버가", Chalk.cyanBright("포트 7777"), "으로", Chalk.bgWhite(Chalk.black("온라인")),"되었습니다.");
console.log(Chalk.magentaBright("[코　인 서버]"), "서버가", Chalk.cyanBright("포트 8888"), "으로", Chalk.bgWhite(Chalk.black("온라인")),"되었습니다.");

//로그인 서버 사용자 접속
loginServer.on("connection", function(socket, req){
    //사용자 IP
    const IP = req.headers["x-forwarded-for"] || req.connection.remoteAddress;
    console.log(Chalk.magentaBright("[로그인 서버]"), "새로운 클라이언트 [", Chalk.cyanBright(IP), "] 가 ", Chalk.bgWhite(Chalk.black("접속")),"했습니다.");

    socket.on("message", function(message){
        const messageJson = JSON.parse(message);
        
        //로그인 요청
        if(messageJson.command == "login"){

        }

        //회원가입 요청
        else if(messageJson.command == "register"){
            const id = messageJson.id;
            const pw = messageJson.pw;
            const name = messageJson.name;
            const email_ID = messageJson.email_ID;
            const email_Domain = messageJson.email_Domain;

            //데이터베이스에서 아이디 목록 불러오기
            const idList = mysqlDB.query("SELECT ID FROM loginData");

            var idOverlap = false;

            //아이디 중복 체크
            for(var i = 0; i < idList.length; i ++){
                if(idList[i].ID == id) idOverlap = true;
            }

            //이미 사용중인 아이디
            if(idOverlap){
                const sendJson = {
                    "command": "register",
                    "result": "idOverlap"
                }
                socket.send(JSON.stringify(sendJson));
                console.log(Chalk.magentaBright("[로그인 서버]"), "클라이언트 [", Chalk.cyanBright(IP), "] 가 ", Chalk.bgWhite(Chalk.black("회원가입")), "[", Chalk.cyanBright(id), "]","에", Chalk.bgRed("실패"), "했습니다.");
            }
            //사용자가 없는 아이디
            else{
                //데이터베이스에서 이메일 목록 불러오기
                const email_IDList = mysqlDB.query("SELECT EMail_ID FROM loginData");
                const email_DomainList = mysqlDB.query("SELECT EMail_Domain FROM loginData");

                var emailOverlap = false;

                //이메일 중복 체크
                for(var j = 0; j < email_IDList.length; j ++){
                    const email = email_IDList[j].EMail_ID + "@" + email_DomainList[j].EMail_Domain;
                    if(email == email_ID + "@" + email_Domain) emailOverlap = true;
                }

                //이미 사용중인 이메일
                if(emailOverlap){
                    const sendJson = {
                        "command": "register",
                        "result": "emailOverlap"
                    }
                    socket.send(JSON.stringify(sendJson));
                    console.log(Chalk.magentaBright("[로그인 서버]"), "클라이언트 [", Chalk.cyanBright(IP), "] 가 ", Chalk.bgWhite(Chalk.black("회원가입")), "[", Chalk.cyanBright(email_ID + "@" + email_Domain), "]","에", Chalk.bgRed("실패"), "했습니다.");
                }
                //사용자가 없는 이메일
                else{
                    //PW 암호화
                    crypto.randomBytes(64, function(err, buffer){
                        crypto.pbkdf2(pw, buffer.toString("base64"), 110800, 64, "sha512", function(err, key){
                            const pw_Key = key.toString("base64");
                            const pw_Salt = buffer.toString("base64");

                            //데이터베이스에 업로드
                            mysqlDB.query('INSERT INTO loginData(ID, PW_Key, PW_Salt, Name, EMail_ID, EMail_Domain, nowLogin) VALUE ("' + id + '", "' + pw_Key + '", "' + pw_Salt + '", "' + name + '", "' + email_ID + '", "' + email_Domain + '", "false")');

                            const sendJson = {
                                "command": "register",
                                "result": "success"
                            }
                            socket.send(JSON.stringify(sendJson));
                            console.log(Chalk.magentaBright("[로그인 서버]"), "클라이언트 [", Chalk.cyanBright(IP), "] 가 ", Chalk.bgWhite(Chalk.black("회원가입")), "[", Chalk.cyanBright(id), "]","에", Chalk.bgGreen(Chalk.black("성공")), "했습니다.");
                        });
                    });
                }
            }
        }

        //아이디 찾기 요청
        else if(messageJson.command == "idSearch"){

        }

        //비밀번호 찾기 요청
        else if(messageJson.command == "pwSearch"){
            
        }

        //비밀번호 변경 요청
        else if(messageJson.command == "pwChange"){
            
        }
    })
});

//메인 서버 사용자 접속
mainServer.on("connection", function(socket, req){
    //사용자 IP
    const IP = req.headers["x-forwarded-for"] || req.connection.remoteAddress;
})