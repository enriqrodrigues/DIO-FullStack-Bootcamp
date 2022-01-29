import express from 'express';
import jwtAuthenticationMiddleware from './middlewares/jwt-authentication.middleware';
import errorHandler from './middlewares/error-handler.middleware';
import authorizationRoute from './routes/authorization.route';
import statusRoute from './routes/status.routes';
import userRoute from './routes/users.routes';

//Instacia a aplicação
const app = express();

app.use(express.json());    //Adiciona um midleware que será responsável por interpretar o content-type e lidar com o json.
app.use(express.urlencoded({ extended: true }));

app.use(statusRoute);
app.use(authorizationRoute);
app.use(jwtAuthenticationMiddleware)
app.use(userRoute);

// //Configura a aplicação
// app.get('/status', (req: Request, res: Response, next: NextFunction) => {
// //Quando chegar uma requisição do tipo get para a rota '/status' ele vai responder 200 com a mensagem foo: 'bar'.
//     res.status(200).send({ foo: 'Sucesso!' });
// });

//Configuração de Handlers de erros
app.use(errorHandler);

//a requisição deverá ser ouvida na porta 3000.
app.listen(3000, () => {
    console.log('Aplicação executando na porta 3000!');
});

