import { NextFunction, Request, Response } from "express";
import ForbiddenError from "../models/errors/forbidden.error.model";
import userRepository from "../repositories/user.repository";

async function basicAuthenticationMiddleware(req: Request, res: Response, next: NextFunction) {
    try {
        //Verifica se há credenciais no header
        const authorizationHeader = req.headers['authorization'];
        if (!authorizationHeader) {
            throw new ForbiddenError('Credenciais não informadas');
        }

        //Verifica o formato das credenciais recebidas: Tipo; Token
        const [authorizationType, token] = authorizationHeader.split(' ');
        if(authorizationType !== 'Basic' || !token) {
            throw new ForbiddenError('Autenticação inválida.')
        }

        //Decodifica o token
        const tokenContent = Buffer.from(token, 'base64').toString('utf-8');
        const [username, password] = tokenContent.split(':');

        //Verificar usuário e senha recebidos
        if (!username || !password) {
            throw new ForbiddenError('Usuário ou senha não informados.')
        }

        //Verificando se usuário e senha estão corretos
        const user = await userRepository.findByUsarnameAndPassword(username, password);
        console.log(user);

        if(!user) {
            throw new ForbiddenError('Usuário ou senha inválidos.');
        }

        req.user = user;
        next();
        
    } catch(error) {
        next(error);
    }
}

export default basicAuthenticationMiddleware;