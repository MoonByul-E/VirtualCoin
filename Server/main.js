const WebSocket = require("ws");
const Chalk = require("chalk");

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