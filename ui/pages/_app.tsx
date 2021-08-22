import "fontawesome/css/fontawesome.min.css";
import "fontawesome/css/solid.min.css";
import "tailwindcss/tailwind.css";
import "styles/globals.css";
import type { AppProps } from "next/app";

function MyApp({ Component, pageProps }: AppProps) {
	return <Component {...pageProps} />;
}
export default MyApp;
