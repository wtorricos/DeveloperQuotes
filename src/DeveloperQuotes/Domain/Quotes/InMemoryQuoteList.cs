namespace DeveloperQuotes.Domain.Quotes;

public static class InMemoryQuoteList
{
    public static readonly IReadOnlyList<QuoteModel> Quotes = new List<QuoteModel>()
    {
        new(Id: 1, Title: string.Empty, Author: "Robert Henri", HtmlText:
            """
            The objective isn't to make art, it's to be in that wonderful state which
            makes art inevitable.
            """),
        new(Id: 2, Title: string.Empty, Author: "Brian Kernighan", HtmlText:
            """
            Debugging is twice as hard as writing the code in the first place. Therefore,
            if you write the code as cleverly as possible, you are, by definition, not
            smart enough to debug it.
            """),
        new (Id: 3, Title: string.Empty, Author: "Greg Young", HtmlText:
            """
            Developers have a tendency to attempt to solve specific problems with general
            solutions. This leads to coupling and complexity. Instead of being general
            code should be specific.
            """),
        new(Id: 4, Title: string.Empty, Author: "M. Conway", HtmlText:
            """
            Any organization that designs a system (defined broadly) will produce a design
            whose structure is a copy of the organization's communication structure.
            """),
        new(Id: 5, Title: string.Empty, Author: "Anonymous", HtmlText:
            """
            If you cannot summarize it on only one page,
            you need to go off and learn more about it!
            """),
        new(Id: 6, Title: string.Empty, Author: "Robert Frost", HtmlText:
            """
            Good fences make good neighbors.
            """),
        new(Id: 7, Title: string.Empty, Author: "Jeff Dean", HtmlText:
            """
            Design for ~10x growth, but plan to rewrite before ~100x.
            """),
        new(Id: 8, Title: string.Empty, Author: "Donald Knuth", HtmlText:
            """
            We should forget about small efficiencies, say about 97% of the time;
            premature optimization is the root of all evil.
            """),
        new(Id: 9, Title: string.Empty, Author: "Mary and Tom Peppendieck - Lean Software Development", HtmlText:
            """
            Defer your decisions until the last responsible moment,
            where the cost of making the decision becomes greater than
            the cost of making it.
            """),
        new(Id: 10, Title: string.Empty, Author: "Julius Caesar", HtmlText:
            """
            Divide et regna.
            """),
        new(Id: 11, Title: string.Empty, Author: "Yaron Minsky", HtmlText:
            """
            Make illegal states un-representable.
            """),
        new(Id: 12, Title: string.Empty, Author: "Heraclitus", HtmlText:
            """
            "The only constant is change."
            """),
        new(Id: 13, Title: string.Empty, Author: "Scott Wlaschin - Domain Modeling Made Functional", HtmlText:
            """
            If you think of software development as a pipeline with an input (requirements)
            and an output (the final deliverable), then the 'garbage in, garbage out' rule
            applies.
            """),
        new(Id: 14, Title: string.Empty, Author: "Jacob Kaplan-Moss", HtmlText:
            """
            Code without tests is broken by design.
            """),
        new(Id: 15, Title: string.Empty, Author: "Pablo Picasso", HtmlText:
            """
            Good artists copy; great artist steal.
            """),
        new(Id: 16, Title: string.Empty, Author: "Elon Musk", HtmlText:
            """
            You should take the approach that you're wrong.
            Your goal is to be less wrong.
            """),
        new(Id: 17, Title: string.Empty, Author: "Bill Harlan", HtmlText:
            """
            It is easier to optimize correct code than to correct optimized code.
            """),
        new(Id: 18, Title: string.Empty, Author: "Andrey Akinshin - Pro .Net Benchmarking", HtmlText:
            """
            Without data you're just another person with an opinion.
            """),
        new(Id: 19, Title: string.Empty, Author: "Linus Tordvals", HtmlText:
            """
            Most good programmers do programming not because they expect
            to get paid or get adulation by the public, but because it
            is fun to program.
            """),
        new(Id: 20, Title: string.Empty, Author: "Tony Hoare", HtmlText:
            """
            There are two ways to write code: write code so simple there are obviously no bugs in it,
            or write code so complex that there are no obvious bugs in it.
            """),
        new(Id: 21, Title: string.Empty, Author: "John Carmack", HtmlText:
            """
            Sometimes, the elegant implementation is just a function. Not a method. Not a class.
            Not a framework. Just a function.
            """),
        new(Id: 22, Title: "Rule of Least Power", Author: string.Empty, HtmlText:
            """
            Given a choice of solutions, pick the least powerful solution capable of solving your problem.
            """),
        new(Id: 23, Title: string.Empty, Author: "Robert C. Martin", HtmlText:
            """
            Abstraction is the elimination of the irrelevant and the amplification of the essential.
            """),
        new(Id: 24, Title: string.Empty, Author: "Robert C. Martin", HtmlText:
            """
            The only way to go fast, is to go well.
            """),
        new(Id: 25, Title: string.Empty, Author: "Leonardo DaVinci", HtmlText:
            """
            Simplicity is the ultimate sophistication.
            """),
        new(Id: 26, Title: string.Empty, Author: "Michael Feathers - Working Effectively With Legacy Code", HtmlText:
            """
            Whenever you are tempted to type something into a print statement or a debugger expression,
            write it as a test instead.
            """),
        new(Id: 27, Title: string.Empty, Author: "Michael Feathers - Working Effectively With Legacy Code", HtmlText:
            """
            Legacy code is any code without tests.
            """),
        new(Id: 28, Title: string.Empty, Author: "Michael Feathers - Working Effectively With Legacy Code", HtmlText:
            """
            Code without tests is bad code. It doesn't matter how well written it is;
            it doesn't matter how pretty or object-oriented or well-encapsulated it is.
            With tests, we can change the behavior of our code quickly and verifiably.
            Without them, we really don't know if our code is getting better or worse.
            """),
        new(Id: 29, Title: string.Empty, Author: "Dave Farley - Modern Software Engineering", HtmlText:
            """
            The route to speed is high-quality software, the route to high-quality software is speed of feedback,
            and the route to both is great engineering.
            """),
        new(Id: 30, Title: string.Empty, Author: "Mark Seeman - Code that fits in your head", HtmlText:
            """
            Software security is like insurance. You don't really want to pay for it, but if you don't
            you'll be sorry you didn't.
            """),
        new(Id: 31, Title: string.Empty, Author: "William Gibson", HtmlText:
            """
            The future is already here - it's just not evenly distributed.
            """),
        new(Id: 32, Title: string.Empty, Author: "Robert C. Martin - Clean Craftsmanship", HtmlText:
            """
            Keeping the code clean. Continuously cleaning the code. That's why we practice TDD.
            We practice TDD so that we can be proud of the work we do. So that we can look at the code
            and know it is clean. So that we know that every time we touch that code, it gets better
            than it was before. And so that we go home at night and look in the mirror and smile,
            knowing we did a good job today.
            """),
        new(Id: 34, Title: "YAGNI Principle", Author: string.Empty, HtmlText:
            """
            You Ain't Gonna Need It.
            """),
        new(Id: 35, Title: "KISS Principle", Author: string.Empty, HtmlText:
            """
            Keep It Simple, Stupid.
            """),
        new(Id: 36, Title: "The Boy Scout Rule", Author: string.Empty, HtmlText:
            """
            Check the code in cleaner that you checked it out.
            """),
        new(Id: 37, Title: string.Empty, Author: "George Santayana", HtmlText:
            """
            Those who cannot remember the past are condemned to repeat it.
            """),
        new(Id: 38, Title: string.Empty, Author: "George Box", HtmlText:
            """
            All models are wrong, some models are useful.
            """),
        new(Id: 39, Title: "Postel's Law", Author: string.Empty, HtmlText:
            """
            Be conservative in what you send, be liberal in what you accept.
            """),
        new(Id: 40, Title: string.Empty, Author: "Rob Pike", HtmlText:
            """
            Data dominant. If you've chosen the right data structure and organized things well,
            the algorithms will almost always be self-evident. Data structures, not algorithms,
            are central to programming.
            """),
        new(Id: 41, Title: string.Empty, Author: "Linus Torvalds", HtmlText:
            """
            I will, in fact, claim that the difference between a bad programmer and a good one
            is whether he considers his code or his data structures more important. Bad programmers
            worry about the code. Good programmers worry about data structures and their relationships.
            """),
        new(Id: 42, Title: string.Empty, Author: "Samuel Johnson", HtmlText:
            """
            What we hope ever to do with ease, we must learn first to do with diligence.
            """),
        new(Id: 43, Title: "The Rule of Three", Author: string.Empty, HtmlText:
            """
            When you find yourself repeating something for the third time, refactor.
            """),
        new(Id: 44, Title: string.Empty, Author: "Jimmy Bogard", HtmlText:
            """
            A broken, dysfunctional organization driven by meeting unhealthy goals and metrics
            will produce broken, dysfunctional systems.
            """),
        new(Id: 45, Title: string.Empty, Author: "Jim Collins", HtmlText:
            """
            If you have more than three priorities, you don't have any.
            """),
        new(Id: 46, Title: string.Empty, Author: "Rip Rowan - Google Letter", HtmlText:
            """
            The golden rule of platforms is that you Eat Your Own Dogfood.
            Can be rephrased as "Start with a platform, and then use it for everything."
            """),
        new(Id: 47, Title: string.Empty, Author: "James Benamor", HtmlText:
            """
            Bad jobs normally come with very good training. Good jobs come with freedom,
            responsibility and a very short feedback loop.
            """),
        new(Id: 48, Title: string.Empty, Author: "dotnetspider", HtmlText:
            """
            Most developers are inclined towards writing code for higher performance,
            compromising reliability and maintainability. But considering the long term
            ROI (Return of Investment), efficiency and performance comes below reliability
            and maintainability.
            """),
        new(Id: 49, Title: string.Empty, Author: "Kent Beck - Extreme Programming Explained", HtmlText:
            """
            Embrace change.
            """),
        new(Id: 50, Title: string.Empty, Author: "Kent Beck - Extreme Programming Explained", HtmlText:
            """
            The customer is part of the team.
            """),
        new(Id: 51, Title: string.Empty, Author: "Agile", HtmlText:
            """
            Fail fast, fail often.
            <br />
            Feedback = Learning
            """),
        new(Id: 52, Title: string.Empty, Author: "David Farley - Modern Software Engineering", HtmlText:
            """
            Accepting that we don't know, doubting what we do know, and working to learn fast
            is a step from dogma toward engineering.
            """),
        new(Id: 53, Title: string.Empty, Author: "Anonymous", HtmlText:
            """
            Always work thinking that you are building a Ferrari, and don't deliver anything
            beneath it.
            """),
        new(Id: 54, Title: string.Empty, Author: "State of DevOps", HtmlText:
            """
            High-performing teams that employ techniques like TDD, continuous integration,
            and continuous delivery spend 44 percent more time on useful work.
            """),
        new(Id: 55, Title: "Scientific Method", Author: string.Empty, HtmlText:
            """
            <p class="fs-2">Characterize: Make an observation of the current state.</p>
            <p class="fs-2">Hypothesize: Create a description, a theory that may explain your observation.</p>
            <p class="fs-2">Predict: Make a prediction based on your hypothesis.</p>
            <p class="fs-2">Experiment: Test your prediction.</p>
            """),
        new(Id: 56, Title: "Go Proverbs", Author: string.Empty, HtmlText:
            """
            <p class="fs-2"> Clear is better than clever.</p>
            <p class="fs-2"> Reflection is never clear.</p>
            <p class="fs-2"> Errors are values.</p>
            <p class="fs-2"> Don't just check errors, handle them gracefully.</p>
            <p class="fs-2"> The bigger the interface, the weaker the abstraction.</p>
            <p class="fs-2"> Don't communicate by sharing memory, share memory by communicating.</p>
            <p class="fs-2"> Concurrency is not parallelism. </p>
            """),
        new(Id: 57, Title: "Zen of phyton", Author: string.Empty, HtmlText:
            """
            <p class="m-0 fs-3"> Beautiful is better than ugly.</p>
            <p class="m-0 fs-3"> Explicit is better than implicit.</p>
            <p class="m-0 fs-3"> Simple is better than complex.</p>
            <p class="m-0 fs-3"> Complex is better than complicated.</p>
            <p class="m-0 fs-3"> Flat is better than nested.</p>
            <p class="m-0 fs-3"> Sparse is better than dense.</p>
            <p class="m-0 fs-3"> Readability counts.</p>
            <p class="m-0 fs-3"> Special cases aren't special enough to break the rules.</p>
            <p class="m-0 fs-3"> Although practicality beats purity.</p>
            <p class="m-0 fs-3"> Errors should never pass silently. Unless explicitly silenced.</p>
            <p class="m-0 fs-3"> In the face of ambiguity, refuse the temptation to guess.</p>
            <p class="m-0 fs-3"> There should be one-- and preferably only one --obvious way to do it.</p>
            <p class="m-0 fs-3"> Although that way may not be obvious at first unless you're Dutch.</p>
            <p class="m-0 fs-3"> Now is better than never.</p>
            <p class="m-0 fs-3"> Although never is often better than *right* now.</p>
            <p class="m-0 fs-3"> If the implementation is hard to explain, it's a bad idea.</p>
            <p class="m-0 fs-3"> If the implementation is easy to explain, it may be a good idea.</p>
            <p class="m-0 fs-3"> Namespaces are one honking great idea -- let's do more of those!</p>
            """),
        new(Id: 58, Title: string.Empty, Author: "Sandi Metz", HtmlText:
            """
            Duplication is far cheaper than the wrong abstraction.
            """),
        new(Id: 59, Title: "Cupid for joyful coding", Author: "Dan North", HtmlText:
            """
            <p class="fs-2"> Composable: plays well with others.</p>
            <p class="fs-2"> Unix philosophy: does one thing well.</p>
            <p class="fs-2"> Predictable: does what you expect.</p>
            <p class="fs-2"> Idiomatic: feels natural.</p>
            <p class="fs-2"> Domain-based: the solution domain models the problem domain in
            language and structure</p>
            """),
        new(Id: 60, Title: "Manifesto for Software Craftsmanship", Author: string.Empty, HtmlText:
            """
            <p class="fs-2"> As aspiring Software Craftsmen we are raising the bar of professional software development by
            practicing it and helping others learn the craft. Through this work we have come to value: </p>
            
            <div class="text-left w-75">
                <p class="fs-3"> Not only working software,</p>
                <p class="fs-3" style="margin-left: 30px"> but also <b> well-crafted software </b></p>
                <p class="fs-3"> Not only responding to change,</p>
                <p class="fs-3" style="margin-left: 30px"> but also <b> steadily adding value </b></p>
                <p class="fs-3"> Not only individuals and interactions,</p>
                <p class="fs-3" style="margin-left: 30px"> but also <b>a community of professionals</b></p>
                <p class="fs-3"> Not only customer collaboration,</p>
                <p class="fs-3" style="margin-left: 30px"> but also <b>productive partnerships</b></p>
            </div>

            <p class="fs-2 w-100">That is, in pursuit of the items on the left we have found the items on the right to be indispensable.</p>
            """),
        new(Id: 61, Title: string.Empty, Author: "Jeff Olson", HtmlText:
            """
            Sometimes you need to slow down to go fast.
            """)
    };
}
