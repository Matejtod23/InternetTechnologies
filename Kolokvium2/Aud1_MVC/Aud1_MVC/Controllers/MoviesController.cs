﻿using Aud1_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aud1_MVC.Controllers
{
    public class MoviesController : Controller
    {
        public static List<Movie> movieList = new List<Movie>
        {
            new Movie () {
            Name = "Shrek!",
            Rating = 5,
            DownloadUrl = "test",
            ImageUrl = @"data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAoHCBYVFRgVFRUYGRYaGiEcHBocHBgeGhocHR4dISEcHBgcIS4nHB8rISEcJjgmKy8xNTU1HCQ7QDs0Py40NTEBDAwMEA8QHhISHzQrJCw0NDY0NDQ0NDQ0NDQ1NDQ0NDQ0NDQ0NDY0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NP/AABEIARUAtgMBIgACEQEDEQH/xAAcAAEAAgMBAQEAAAAAAAAAAAAABQYDBAcBAgj/xAA9EAABAwIEAwYDBQgCAgMAAAABAAIRAyEEBRIxBkFRImFxgZGhE7HwBzJCUsEUI2JyotHh8YKSQ7IVMzX/xAAaAQEAAwEBAQAAAAAAAAAAAAAAAQIDBAUG/8QAJxEAAgICAQMDBAMAAAAAAAAAAAECEQMhMQQSQRMiUQUyYcGBkeH/2gAMAwEAAhEDEQA/AOzIiIAiIgCIiA8ReLBi8RoYXbxsOp5BVlJRTbC2bCKs5Jnz6mIqUKmnsta5pAj72q39JVmVMWWORWiWq0EULnGetonQ0aqnTk3pP9lBVMdVqXdUdHRpgeg/Vc+frceF09slRbLsF6qXQc5p7LnA9zipTB5u5pAqXb+b8Q8Rz+awxfVMUpdstEvG0WFFjY8OAIMg3BWReoUCIiAIiIAiIgCIiAIiIAiIgCIiA8WpmGE+Kwt1Fp3BHIju5rbRVlFSTTBSq2S4ii81QWVIg6mNLXw3aWGZAk7E7mykq/EzBQc8R8QNs07EnYz05qxrluYUW1cVWDT+7D4AG0wNUd2vUuDNFdMu6DpPlF1vTIv4b65JdUcJJLyPvPJ7+Szsy1lO7H1GHkQ63yupV2RnSBTd4gmJHMBw2+rrXwuXPa6p8RtnDsaQxppm0Amf3jd51ajtEGSfOWWOS/cl+H5NVFpErkVWWlr3F55OIAPss+a4plKOy8z+UTHio/LMLpcSDabRda2eOLJe6Y8+7ax69Op2BI5FCM8lV+i26Jvh3ialr+CXOAeezqEQ4mNPdPz8VdFy7D4cPYxzwHMfOh0kkEbtMta5jrHaxixVtrZ+QwNY1zqkAEkTeLkNF3Fe10/URxx9Od6482Yyje0S2IzKmxwY53aPTlPXot1UDCNrOfD6FaSSdZY+CTvJIsr5RnSJ3gT4wujp8uScpdypeCrSSVGVERdZUIiIAiIgCIiAIiIAiIgCIiAj87xfwcPVqDdrCR/NED3IXM8kMMkbq4/aFiA3CFsiXuaIm5AOo26dlV3KWBlBxAvoPrG68n6lOkkXhyfWHxtcuEMaGdXOgkddIC0+IMfiWOL20S9gb+EiZm9tzy9FsVjqfLXEQABzFhzC3qGKLfvsc4dWDV/T972XlpdslLtT/But6sh+GuKKTmjWSw7HUCL9D0Uzjc9w7i0OqU4cYALm3PgswwuDrXLWa+hGh/mDBXrckwzbtp0iesNJ9TdMjht015r/AElWfWGoUvvNAlTmRtaC6ANW88yOnr81XMfhWv7LHaHj7padjyBA3HipLhiq8uaHiHaDqHp+qnoZNZ4yT500yuT7S1r1EX1JzBERAEREAREQBERAEREB4i18Xim02y7yA3Kp2dZ/ULHkO0NDXGG9IO53J9FVySJSs0s342qMxRFJzTRZ2dJEh5G7gRcXsL8uaxZr9oT3M00GimY7TiQ4g9G8vMyub18UGQN5Blaj8a4tDWtIBMcweU2G5WVyZekWDE5i+q8uc4utJJuSeRnfaVYsgxwc3QekKl5VuZkyTvvZbmHxBpvkdVxdTj77RF07Lax0G/KylcNX9FC4PFMqAGYJ3VgweFaRuvJ6iorZrHfBssdIuAR3gH5rw4dkzoZP8jf7LYGXnkVjqUXBcbnJatpGls8s0WAWKnnNPDV2fEmHhzdQBOkgarx4bLyu/SL7BVriS7KTju+p2bwQA11x4gu8l2fT4v1lJv5M5O9HVqFdr2hzHBzXCQ4GQR3EL01WhwbqGoiQ2RJA5gbrjDczxOH106FV7NQDiBG5mS0OnSSBuOa94ELzmDC4uc7VL3EuJDTTeBqJ3l0C/wCbvX0yyJmTjR2xERaFAiIgCIiAIiIDxY61UNEn/Z6L7c6BJUViq+ozy5f3VJS7USlZGZjVLiS6/wCn+FQONMUWUH6ZGohvhLgT7Aq4Zxig0H63XOOK8TrYGjdzxHlJ/wAeaxjtlitUHm7nDUZsD5bdd181awAO0zf+G+36yvphd2YZIGwEc49TMeR7lq4qrrvEOEtI6DaO82MlaJbDJzLndiRyfB8/oLer05UVklXU5zDs5tulug52+Sm8PcQdxYrnzKtg0qdRzNjBCs2U5/AhxgqDrUZWs4Ob3+IXLOEMiphWuDo2Hz9p/EPVbT83aBqLgucYGg+oYYwd5vAVqy3IgI19o+w8AvPzdNhjy/4NFKTN+i92JfMFtIcz+Pw7u9QvE+N+I9jGTpZ27RBAloMT2gZdtcaOam8bitILGdljBL6lgI0kw3qfKFRca8ve59uulwuwAFoaPAQ7nJnqu3o8Fe9qvhA2KWrSXiDJ1EbuZv2XDum0dOas3AODPx8U8jsgMYD1mXEDwGn1CrH7U0AS2WEhpAm8EsAg89U9kkW7wr7wcIouItqqOPfs0X6G3su8PgteFxOk6XEkcj07lJKHIELawNS2k+R7ui2hLwzJo30RFqVCIiALxFgxdbS225sFDdKwauPxF9I2G/iorEVgAvqs+bSorF1hcdy5ZNydmiVFfz7F7hUHM6+upo/KO6ST0ny91ZM2xMuKqHxiXOfPM30zz5HktIqkQts+X0i06g2CLTpAuehBtYwDECdlrfB1C976Y3IG/pPPdSJqWkETBki7iI3l3PpB6rHTJDSCXNuCDaDG5BJg9QNyptlqRjwDNFRpfIh25mRG46d3fKt1DAvqAvp3jcGRPPbptdV5tRzbNdLfzW1aeQ7MC8x1W9lWYvpvD2kASAQJMzYzIAkwPS3KKy2hSJ9uVVHGAGn/AJBSOC4bBP7x09w2U87Ai9reA/VfLMraBub8gSI9PL0XFPDKX2uv4JVGSlhKVNoBIaOQG58ua8qYV1U6GjRTm7p7TogkRyG47/dY62Kw2HA1vlwiQLkfoL9SNlVuIOK3VtbGAsZomAZcS0yA5wFmmIgW62KjH0kIvue2TbZk4lzhjnfs9HSadMgEEz8QmW9/ZBg7X36E17CsLmEzIEOIO4fpALQ43iAD5ha2IEHQ5g0/eYZkN1iJnk0EEzuLeK2qeNOkuDmNbUmA6Rpc0Bu9hBidrLsrQR94mvLTYHUWl0gix2aTMQXHfvPnfuHcQGUWN2JGoz/EZE94BHoubgufaRvocAbEaoMHmRAPn3q24XGch5eASiJMvlDESFtNfEEcrqrZfjJU/h6sx9eCFScoVQ4SPPuKyqLw9TS6Zsd1KLeMrRRqj1ERXIPFFZrU7QHID3P0FKqDzF37xw8PkFnlftLR5IrEOM2/yqxmuNexxLhLTzHJWmuVA5zSDmmWrnjyWZzzOsXDhGzjYqKw4AF7GenReZ/QcxxE9nlfZS2Iyw1GsrMa1gfTYdDZgEMaDv1ILr/mXR4KrTNMPBNy2fMxHIagbHoZ8V9MEFzgCCbHS5pEmZ/EO7uXwaL2Tq1EwQDJtbogxFoJufzulovuJE9N5sq0WszsLL27U7yN+p2vuRbZeUMvcxjq7ahY2m4Q5wBl9iAGk9rl7eJ9w7NTgACSTDe8zAAgxuN55LqOW5RSYxg0NJAuTzJFyRz5C/IKrl2irKLT4kzR76bGloJPZOhgDzBMPMEA22ELJj8yzZjdFZwa19pAptPgHMaCrHjcmqVKjvhODCyqyqxzgdOpsggxfYnbmFJ8Y0Zw4daWumeidy+ERRzNjajmnW5ou1paXS7SZlzBNx96faAFma4x2g3UdAc2dJ7OsnlG49gstek5oLi2Wg7kGJ/LMQJEbwvnT924ix2M35Q0QR0/yjdl0YH0xsCQLnlYnVG82AkWjkT1WWhTMRIBAk6i7nIcdyCCJkxBtEG6y0aTQ6G6SCRe9jciGi3n3BZHG4AAtyl38WwItPQWUNkpGqx/ZIgGBtuQdI7ZJAOrl5HdbGGxpBBPRfGGA1tDyXNP3rwYJ7W5EEyY5fp7hsmxDhWe1hdTo9ovlo7B1Q6JmwaZiYVo7KSLNlmMBgyrjgK2oDmuVYTE6XCL9y6HkuJc5ghoA6ndRJUQmWVh8VI4GrqbHMW8uSiKTjF4W5gnw8DqI9FMHTDWiWREW5Q8UDnLS1+rk4e4t/ZTy0s0w+thjcXH6hUmrRKeyt1qkiVW83qktMFWB5tYKt5mztFcyLnPc8w5dKteEoxQpN5imwejAofM2C6sVMQxn8rfkFreivkj30pMEAr5dkYebMPXuUgwDV3KYosmFW6JI7LMgZTIcGy4Tck/ImJ/urLRYQFrgFSeHBAHX5qjlbLUa4qFu6i+KarnYeBNz+isTmNNiF6cM0iCPW/1soBx01nEaXh4dDWuAmHadg4be3PyXjsQ7U6DpP5XQx1yALnl4zv5rsdPLGTqLGl3UgSFq5hw3QrO1PYNXMwL+SupfgHKximi5e0xJGoyQdTRuN/xH0XoeH2Y4XnmSJEAAg9RJFuS6pQ4ewzBAos8xJUbX4Hwz3aw1zJuQLJaFlAbb8MA+EgwDbuA+avPDjQ3B4x5brZ8ItvYPOl0gEdJAJHXqFujgvB6mu0XbykwfEc1m4rxoo4Gq1sDXppsFoAMyI5dhrlaPJEno5fg2l7w1xDfASuh5JggwNDXuPiqpkmVPMPZUZJG0f3V2ywvZ99o8QkmQkTdFsDdZcOe22PzeywteCOn11WbAjVUH8Mk/L5lRHlBk2iIukoEREBT85omnUcAOy7tN6d49VDYyi2C6Lm6t/EWHc5ge0Dsai7rpiTHoudY/PmjssYXOjy7xbmFyTXbIunorWfMAn3U3h3yxh/gb8lVc1bVqvOrst6DZT2AfppMbMw2PSyummiDaY6CpPB1VBuetzB17XVWiSxUKs+qksMXc1B4Oo02spuhU+rqtFjbaIg2X3TPX1WKmZhbLWW8VAM7Hj6lffJa7GQsupWIDReI+hP+F9vp/X+F40+q+tSA1atr/ouf8cYh7qlKiA4sgvcG9dh7F3quhYk2/wBeq5/iW/tOJeWOc0M7GsRBLTfT1Adae6FWU1Bd0uByb2SUKTWjRLTzB3Cs9KhbqFBMw2loLzq0/iiHDvMW+SlMNUeBAMjr3KmPLHIri7JqjZqVbx05qbyqhpbqO7r+XIfr5qEyugatQyDpae10PQeZ9grUurHHyUkz1ERbFQiIgNLNHAUahP5He4K5pWAvYSul5nQNSk9jfvFtvHcLmeOwGIa17n0HtY3dxFo8jt3rzurhOUk0tUWRWs1deyw4DEW0nxC8drrvIpUatTSd2Me8eekGFoswmI+IWPo1KbtJczWx7O0LtEuGx281rii0kReya1L1lWFFYLMA8QbO2IO4I7lva+a1aLE3gaxU9hcTJg/Xiqlg64mOansJWiJHieayaJLCxxmxWyyq6FFYesP9lblOo42IAHXf2UEm7TqXWYu71oNN5H6LLrmLogbYfJ7kdVA8FpurRf8A3CjM1zVlNhc90D6tEoDHneatD6dAu0/EBlwNw2wgEXEnn3FfLm0sL2RpAjuH+1R6FJ+Y4l9QuLGMADRMHTJgyAd4PJWrB4ei09vUXtOk63FxBHSTA8lx9Wlw7f6LRJPDV/iBznDSDYA2Mde5R/D9Z2qpQu5zXlrdjIsQPf35bLOzGtc4saLNvPIDvP6KZ4V4bdSrVMTVcC5/3Wiey2Lap/FHLvVPp8Jd7XikRNllwGFFNgbz3J6k7/28ltrxer20qMQiIpAREQBERAfICguMXxhyPzOaPQ6v0U+qTxxiSXtp/ha3X4lxI9gD6qsnSCOYcQZSXO+NSs/dzR+LvHf81E4XNY7L7EWM/r0VtxDrwOSjMflbKtyIf+Yb+fVZKXhlzBSxDTBBClcJj9gTCqmIyitTMsOofw/q0/pKwDGVGWc2D3gg+6ntT4ItnR6GKbaXSVLYfHiLFcnZm7hy/qP9lnOc1A0GHAHYk2MeV1X0ybOrf/IAHfdYsTnTGCXOAHeVzDD4vE1jpZreZiGNLo8SJjzViy/gbE1HB1d4Y3oTrfHOwMD18lVxS5LG3mPFwPYpAucbC25OwAFz4LBjckqii7E4snXsynP3ZMS/8vPs79Y2V4yThvD4YaqbJeReo+HP8AdmjwhffEGHJw1UNaHnQYETy6dVFom/g5fkr6wxIZRcG6mEGfu6R3DntHirFhcK34j/AIzy59pAIDTYQRAFohUvEYl9J4cyWvbta89CCrPluQuqVP373VnvYH6acxF7O03+W6y6mFq7/rkrFlpyEsr1vgsjQ06nxsAItI5k2810dVvhbJP2dpOgMEQ1oiQDBJcRzsOqsi16TF2Ruqb+eSJO2eoiLrKBERAEREAREQHipXG+FfrbVDHOZo0uLQTpILjJA5XV1WHFs1Me3q0j1BVZK0DllPIy8a2PF/rdauJyaq3eI8VDcP8AFJodirJbNiOkXkd1r96uhx7KgDmEEEcj1v5rlbaNKIRmXH8RhbbuG8NWAFQOJHQkfJZ6h6LJhzdO5g1RwJgnfhf/AN3D3CmMLwtg2FsYelYWLmhztt9TpM962MI5bjTeU7n8g+mUmNENAaOggey+pCabLGwAG58FBJtUyfL69l7VqhoJcRH+1DZnxLQoENc4F5tpbdw73AbAWuVUs44mdWaWgQ0yN51NNoI228d91EpKJaMXIjMFh24nNGMEOaa+p3MaWEucD5DSu8Bcz+zHLW/EfUDQAxsbfid/gO9V01dOJ90bM5pJ0F6iLUoEREAREQBERAEREAREQH5kzvD/AA8RWp/kqPb/ANXELFgMxqUjLHECZLeRifTcqd+0bC6MwxAGznNeP+bWk+8qqrGjQt+F4taZD2xe259x0+grjklJ+IptrU2PLCSAY30mDAN95ExyK460L9P5JgBh8PSot2YxrZ6kC58zJ81HpxbIbK1Qw1Vo/wDqf/1P9ltfBqEWpP67R5XVqRT6S+SLKxXw1VlN7y2AxhdpmXHSCYAHOy5DmvHeIqmKcU2coA1RA3N457L9COE77L8vZ7hWUcTXpMMsZVexv8rXkAeUR5KfTigpM+sPUuTzJknqepUrSJMBQ+Xs1O3VlwmHhcuZpM6MabR1zgbAilhGHm+XnzsP6QFYlgwlIMY1gsGtAHgAAs67YKopHNJ22z1ERWICIiAIiIAiIgCIiAIiIDg32q//AKFT+Wn/AOgVKOy6H9sOFLcWypyqUx/2aSCPTT6rnzQSsuLNPB4xfpXhTFGpg8M9xlzqLCT1OkAn1X53wmXufE2Huv0bw/gvgYWhS/JTa0z1DRPvKQknJpESWkSaIi1KHhX5SrVS973nd7nOPi4kn5r9Wr8u5jhDRxNakf8Ax1Hs8muIB8xB81VlkMBT7Y5dVa8vu4NH4iAPkoDCUpdKuvAmA+NiWW7LO27y2/qj3XFl97UToh7VZ2BogL6Xi9XecoREQBERAEREAREQBERAERa+Lc4McWRqDSWzMSAYkDlKA599s2GBw9CpzbULfJzST7tC5Xg40lTvEvF9XGsbTxHwmFjz2G6gdURLg5xI5iOSi8FhDp635LmyteTaCZZuAcr/AGjEtDh2Wdt3eGxA83R5Su2hcc4Mzf8AZcVRp6JbiSWGNwQW6XeRNx0JPJdjVsCXb3LyVy/ceoiLczPF+f8A7UcMKeaPI2qNY/zLdJ/9fdd1zKu6nSqPa0Oc1jnBpMBxaCQCYMT4L87Z/wARtzDENrvDaZ0taWyYaGzzIvuqy4LR5M2A6rrv2b4IMw7qkdqo7+lth76lxujm9BkgvJ5yGkjwnr7W3XR/s74/w1QNwlT9y9pimXEaasnadmvkxp52g8lzYoPv7mjWcvbVnT0RF1mAREQBERAEREAREQBERAeLBi8U2kx1R7g1jGlzieQAklZ1yb7UeLGvBwVB2oAzWcNjpuGA84ME+AHVCUrOW5vWOIr1cRp0mo99QNtbU4kA991mweJqta3SGPBEtJjUO64my+6NO5gWsPPey2Gtgkx4+HJUlT5LxVE59nwNTMaJxLjHaNMAmG1AJaSfAOHfZd+X5/4OwzqmMohgJeKjHGBZjGOBc49Bbn3Dov0ApjwVlyeoiKxU1cwxTaVKpVd91jHOd4NBJ+S/K9WhLi5sN5xuB3Bd8+1jEuZl1QNtrexhPcXSfWI81wZjpg/XmoZZIwtwrnhpJAk7RcDabeBsusfYzkeHqUq9dzA9znCkWPhzWtAY8jSRvqO56Bc6iRLZn6tvsrp9m/FLMI51OrajVIJeB9x4tLo3BsCeUDvUJktHbkWKnUa4BzSHNIkEEEEHmCNwsqsUCIiAIiIAiIgCIiAIiICk/ahmtWhhWikS01H6HPG7RpJgHkXRE9AVxmgzrzX6OzTLqeIpupVmB7HC4PsQRcEG4IuFzbMfswrMcThq7Hsnstqghze7W0EO8SAqyT8F4NLkpGHwJcJaOa28PlJfVpUQSPiVGsPdJguE7wJKuGXcEYwQHii3qdbnC3QBqtvD3CbMO74jz8SteHEANbO+ht4mTcknwWajJvZpKUUtcknkuS0MKzRQpho5ndzj1c43cVJoi2MAiIgI/NsrpYmk+jWYH037i42Mggi4INwQuG8acFvy54exxfhnmGvIGpjt9D4sZEw60wduf6BUbnuUsxVCpQfs9sA82uF2uHeDBQlH5xw4JG2/1uttmGvfnfwO0wpLM+E8bg3dug57ATD6bS9hHUht2f8AIDzXuHqMfG+o2DQDPK2lYytG0aaN/hPiurgnhnafQJuw3LRN3MPIjpsfddvo1Q9rXNMtcAQeoIkFcjyLg6tXe1z2Op0gZc5w0uI6Na65J6kRHXZdcpMDQGgQAAAOgFgFeNmc6vRlREVygREQBERAEREAREQBERAEREAREQBERAEREAXzC9RAeoiIAiIgCIiAIiID/9k="
            },
            new Movie () {
            Name = "Shrek!",
            Rating = 5,
            DownloadUrl = "test",
            ImageUrl = @"data:image/jpeg;base64,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"
            }
        };

        public static List<Client> clients = new List<Client>(){ };
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllMovies()
        {
            return View(movieList);
        }

        public ActionResult ShowMovie(int id)
        {
            MovieRentals model = new MovieRentals();

            model.clients = clients;
            model.movie = movieList.ElementAt(id);
            return View(model);
        }

        public ActionResult ShowClient(int id)
        {
            var model = clients.ElementAt(id);
            return View(model);
        }

        public ActionResult NewMovie()
        {
            Movie model = new Movie();
            return View(model);
        }

        public ActionResult NewClient()
        {
            Client model = new Client();
            return View(model);
        }

        [HttpPost]
        public ActionResult InsertNewMovie(Movie model) {
            if(ModelState.IsValid == false)//vrakjame istoto view so istiot model nema da dozvoli da prodolzime ponatamu so nevaliden model
            {
                return View("NewMoive", model);
            }

            movieList.Add(model);
            return View("GetAllMovies", movieList);
        }

        [HttpPost]
        public ActionResult InsertNewClient(Client model)
        {
            if (ModelState.IsValid == false)//vrakjame istoto view so istiot model nema da dozvoli da prodolzime ponatamu so nevaliden model
            {
                return View("NewClient", model);
            }

            clients.Add(model);
            return View("GetAllMovies", movieList);
        }

        public ActionResult EditMovie(int id)
        {
            var model = movieList.ElementAt(id);
            model.Id = id;
            return View(model);
        }
        [HttpPost]
        public ActionResult EditMovie(Movie model)
        {
            if (ModelState.IsValid == false)
            {
                return View("NewMovie", model);
            }
            var forUpdate = movieList.ElementAt(model.Id);
            forUpdate.Name = model.Name;
            forUpdate.ImageUrl = model.ImageUrl;
            forUpdate.DownloadUrl = model.DownloadUrl;
            forUpdate.Rating = model.Rating;
            return View("GetAllMovies", movieList);
        }

        public ActionResult DeleteMovie(int id)
        {
            movieList.RemoveAt(id);
            return View("GetAllMovies", movieList);
        }
    }
}